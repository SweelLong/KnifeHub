﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PluginCore;
using PluginCore.Interfaces;
using QQChannelFramework.Api;
using QQChannelFramework.Expansions.Bot;
using QQChannelPlugin.IPlugins;
using QQChannelPlugin.Utils;

namespace QQChannelPlugin.Controllers
{
    /// <summary>
    /// 其实也可以不写这个, 直接访问 Plugins/ZhiDaoPlugin/index.html
    /// 
    /// 下面的方法, 是去掉 index.html
    /// 
    /// 若 wwwroot 下有其它需要访问的文件, 如何 css, js, 而你又不想每次新增 action 指定返回, 则 Route 必须 Plugins/{PluginId},
    /// 这样访问 Plugins/HelloWorldPlugin/css/main.css 就会访问到你插件下的 wwwroot/css/main.css
    /// </summary>
    [Route($"Plugins/{nameof(QQChannelPlugin)}")]
    public class HomeController : Controller
    {
        #region Fields

        private readonly IPluginFinder _pluginFinder;

        private readonly bool _debug;

        #endregion

        #region Ctor
        public HomeController(IPluginFinder pluginFinder)
        {
            _pluginFinder = pluginFinder;
            string debugStr = EnvUtil.GetEnv("DEBUG");
            if (!string.IsNullOrEmpty(debugStr) && bool.TryParse(debugStr, out bool debug))
            {
                _debug = debug;
            }
            else
            {
                _debug = false;
            }
        }
        #endregion

        public async Task<ActionResult> Get()
        {
            string indexFilePath = System.IO.Path.Combine(PluginPathProvider.PluginWwwRootDir(nameof(QQChannelPlugin)), "index.html");

            return PhysicalFile(indexFilePath, "text/html");
        }

        /// <summary>
        /// 将所有 settings.json 中的 bot 尝试登录
        /// </summary>
        /// <returns></returns>
        [Route(nameof(Login))]
        [Authorize("PluginCore.Admin")]
        public async Task<ActionResult> Login()
        {
            SettingsModel settingsModel = PluginCore.PluginSettingsModelFactory.Create<SettingsModel>(nameof(QQChannelPlugin));
            // 确保以前的都取消
            #region 确保以前的都取消
            foreach (var item in QQChannelBotStore.Bots)
            {
                try
                {
                    await item.ChannelBot.OfflineAsync();
                    await item.ChannelBot.CloseAsync();
                    item.ChannelBot = null;
                    item.OpenApiAccessInfo = new OpenApiAccessInfo();
                    item.QQChannelApi = null;
                }
                catch (Exception ex)
                {

                }
            }
            QQChannelBotStore.Bots.Clear();

            #endregion
            foreach (var botConfig in settingsModel.Bots)
            {
                ChannelBotItem(botConfig, settingsModel);
            }

            // TODO: 暂时这么做, 以后优化界面
            return Content("尝试登录 设置 里的 QQ频道机器人中, 请耐性等待! 注意查看控制台!");
        }

        private async void ChannelBotItem(SettingsModel.BotDevItemModel botConfig, SettingsModel settings)
        {
            // https://www.yuque.com/chianne1025/mybot/otkzzg

            // 声明鉴权信息
            OpenApiAccessInfo openApiAccessInfo = new OpenApiAccessInfo();
            openApiAccessInfo.BotAppId = botConfig.BotAppId;
            openApiAccessInfo.BotToken = botConfig.BotToken;
            openApiAccessInfo.BotSecret = botConfig.BotSecret;

            // 使用QQChannelApi获取相应的Api接口
            // 鉴权信息在实例化时传入
            QQChannelApi qChannelApi = new(openApiAccessInfo);

            // 指定Api请求使用Bot身份
            qChannelApi.UseBotIdentity();

            if (botConfig.UseSandBoxMode)
            {
                // 指定Api通道模式为沙盒模式 (测试时使用)
                qChannelApi.UseSandBoxMode();
            }
            else
            {
                // 不指定的情况下默认是正式模式
                //qChannelApi.UseReleaseMode();
            }

            // 实例化一个 ChannelBot,该类是一个容易理解且简单的类
            // 帮助你快速实现一个利于理解学习与开发的机器人原型
            // 将鉴权信息 (openApiAccessInfo) 传入构造函数
            ChannelBot channelBot = new(qChannelApi);
            // 注册接受@机器人消息时间，否则无法收到消息
            channelBot.RegisterAtMessageEvent();

            #region 事件

            // 为链接官方平台成功事件绑定一个回调函数
            channelBot.OnConnected += () =>
            {
                Utils.LogUtil.Info($"{openApiAccessInfo.BotAppId} 连接成功");

                var plugins = _pluginFinder.EnablePlugins<IQQChannelPlugin>().ToList();
                Utils.LogUtil.Info($"响应: {plugins?.Count.ToString()} 个插件:");
                foreach (var plugin in plugins)
                {
                    Utils.LogUtil.Info($"插件: {plugin.GetType().ToString()}");

                    plugin.OnConnected(openApiAccessInfo.BotAppId);
                }
            };

            // 为鉴权成功事件绑定一个回调函数
            channelBot.AuthenticationSuccess += () =>
            {
                Utils.LogUtil.Info($"{openApiAccessInfo.BotAppId} 机器人已上线");

                var plugins = _pluginFinder.EnablePlugins<IQQChannelPlugin>().ToList();
                Utils.LogUtil.Info($"响应: {plugins?.Count.ToString()} 个插件:");
                foreach (var plugin in plugins)
                {
                    Utils.LogUtil.Info($"插件: {plugin.GetType().ToString()}");

                    plugin.AuthenticationSuccess(openApiAccessInfo.BotAppId);
                }
            };

            // 为机器人出现异常事件绑定一个回调函数
            channelBot.OnError += (ex) =>
            {
                Utils.LogUtil.Info($"{openApiAccessInfo.BotAppId} 机器人出现错误 -> {ex.Message}");

                var plugins = _pluginFinder.EnablePlugins<IQQChannelPlugin>().ToList();
                Utils.LogUtil.Info($"响应: {plugins?.Count.ToString()} 个插件:");
                foreach (var plugin in plugins)
                {
                    Utils.LogUtil.Info($"插件: {plugin.GetType().ToString()}");

                    plugin.OnError(openApiAccessInfo.BotAppId, ex);
                }
            };

            // 为接收到@机器人事件绑定一个回调函数
            // message 为收到的消息内容
            channelBot.ReceivedAtMessage += async (message) =>
            {
                Utils.LogUtil.Info($"{openApiAccessInfo.BotAppId} 机器人收到消息 -> {message.Content}");

                var plugins = _pluginFinder.EnablePlugins<IQQChannelPlugin>().ToList();
                Utils.LogUtil.Info($"响应: {plugins?.Count.ToString()} 个插件:");
                foreach (var plugin in plugins)
                {
                    Utils.LogUtil.Info($"插件: {plugin.GetType().ToString()}");

                    plugin.ReceivedAtMessage(openApiAccessInfo.BotAppId, message, qChannelApi);
                }

                if (botConfig.UseDemoModel)
                {
                    // 使用QQChannelApi异步回复一个与用户发送一样的消息内容
                    // 发送消息时，如果机器人中的一些能力未联系官方开通，会导致发送失败，或者发送成功但需要等待官方人工审核
                    // 发送失败或需要等待官方审核时会抛出异常，请注意捕获
                    await qChannelApi
                        .GetMessageApi()
                        .SendTextMessageAsync(message.ChannelId, $"收到消息啦！您发送的消息为 -> {message.Content}", message.Id);
                }
            };

            channelBot.ReceivedDirectMessage += async (message) =>
            {
                Utils.LogUtil.Info($"{openApiAccessInfo.BotAppId} 机器人收到消息 -> {message.Content}");

                var plugins = _pluginFinder.EnablePlugins<IQQChannelPlugin>().ToList();
                Utils.LogUtil.Info($"响应: {plugins?.Count.ToString()} 个插件:");
                foreach (var plugin in plugins)
                {
                    Utils.LogUtil.Info($"插件: {plugin.GetType().ToString()}");

                    plugin.ReceivedDirectMessage(openApiAccessInfo.BotAppId, message, qChannelApi);
                }
            };

            // 仅私域机器人可用, 在频道内无需 at
            channelBot.ReceivedUserMessage += async (message) =>
            {
                Utils.LogUtil.Info($"{openApiAccessInfo.BotAppId} 机器人收到消息 -> {message.Content}");

                var plugins = _pluginFinder.EnablePlugins<IQQChannelPlugin>().ToList();
                Utils.LogUtil.Info($"响应: {plugins?.Count.ToString()} 个插件:");
                foreach (var plugin in plugins)
                {
                    Utils.LogUtil.Info($"插件: {plugin.GetType().ToString()}");

                    plugin.ReceivedUserMessage(openApiAccessInfo.BotAppId, message, qChannelApi);
                }
            };

            #endregion

            // 保存起来
            QQChannelBotStore.Bots.Add(new QQChannelBotStore.BotItemModel()
            {
                OpenApiAccessInfo = openApiAccessInfo,
                QQChannelApi = qChannelApi,
                ChannelBot = channelBot,
            });

            // TODO: 可能放在这里上线不合适
            // 完成以上配置后将机器人上线
            await channelBot.OnlineAsync();
        }

        [Route(nameof(Download))]
        [Authorize("PluginCore.Admin")]
        public async Task<ActionResult> Download()
        {
            string dbFilePath = DbContext.DbFilePath;
            var fileStream = System.IO.File.OpenRead(dbFilePath);
            //System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();

            return File(fileStream: fileStream, contentType: "application/x-sqlite3", fileDownloadName: $"{nameof(QQChannelPlugin)}.sqlite", enableRangeProcessing: true);
        }
    }
}
