﻿
<h1 align="center">KnifeHub</h1>

> 工具平台 | 日常生活/学习/工作/开发 工具集 | QQ、Telegram、微信、钉钉、浏览器自动化、打卡、QQ频道

[![repo size](https://img.shields.io/github/repo-size/yiyungent/KnifeHub.svg?style=flat)]()
[![LICENSE](https://img.shields.io/github/license/yiyungent/KnifeHub.svg?style=flat)](https://github.com/yiyungent/KnifeHub/blob/master/LICENSE)
[![Telegram Group](https://img.shields.io/badge/Telegram-Group-blue)](https://t.me/xx_dev_group)
[![QQ Group](https://img.shields.io/badge/QQ%20Group-894031109-deepgreen)](https://jq.qq.com/?_wv=1027&k=q5R82fYN)
<!-- ![hits](https://api-onetree.moeci.com/hits.svg?id=KnifeHub) -->
[![docker pulls](https://img.shields.io/docker/pulls/yiyungent/knifehub)](https://hub.docker.com/r/yiyungent/knifehub)
[![docker version](https://img.shields.io/docker/v/yiyungent/knifehub/latest?label=docker%20image%20ver.)](https://hub.docker.com/r/yiyungent/knifehub)
[![Docker Image CI/CD - Release - knifehub](https://github.com/yiyungent/KnifeHub/actions/workflows/docker-push-knifehub-release.yml/badge.svg)](https://github.com/yiyungent/KnifeHub/actions/workflows/docker-push-knifehub-release.yml)
[![Github All Releases](https://img.shields.io/github/downloads/yiyungent/KnifeHub/total.svg)](https://hanadigital.github.io/grev/?user=yiyungent&repo=KnifeHub)



## Introduce

工具平台 | 日常生活/学习/工作/开发 工具集 | QQ、Telegram、微信、钉钉、浏览器自动化、打卡、QQ频道

- **Web 可视化** - 无需再在 Console 上操作, 轻松上手
- **插件化架构** - 轻松使用插件扩展
- **多平台多架构** - win,linux,osx,amd,arm 均可

> **注意** : **QQBotHub** 更名为 **KnifeHub** , 将不再局限于机器人开发

> **通知**         
> 请尽快更新到 最新版 (KnifeHub-**v1.0.0** +)

> **注意** : 本项目仅供学习使用, 所有第三方插件与本项目无关


## 功能

- [x] **大部分功能由插件提供**
- [x] 本仓库 维护的 官方插件
  - [QQChannelPlugin](https://github.com/yiyungent/KnifeHub/releases?q=QQChannelPlugin&expanded=true)
    - [x] QQ频道 基础插件, 可依赖本插件开发相关插件, 提供事件派发, 机器人管理
    - [x] 依赖 [Chianne1025/QQChannelFramework](https://github.com/Chianne1025/QQChannelFramework)
    - [x] 订阅频道消息/私信 
    - [x] 多频道机器人管理
    - [x] 沙盒模式
    - [x] 演示模式
  - [KonataPlugin](https://github.com/yiyungent/KnifeHub/releases?q=KonataPlugin&expanded=true)
    - [x] QQ 基础插件, 可依赖本插件开发相关插件, 提供事件派发, 机器人管理
    - [x] 依赖 [KonataDev/Konata.Core](https://github.com/KonataDev/Konata.Core)
    - [x] 账号密码/配置 登录 
    - [x] 订阅私聊/群聊
    - [x] 演示模式
  - [SoraPlugin](https://github.com/yiyungent/KnifeHub/releases?q=SoraPlugin&expanded=true)
    - [x] QQ 基础插件, 可依赖本插件开发相关插件, 提供事件派发, 机器人管理
    - [x] 依赖 [Hoshikawa-Kaguya/Sora](https://github.com/Hoshikawa-Kaguya/Sora)
    - [x] 对接 `go-cqhttp`
    - [x] 订阅私聊/群聊等
    - [x] 演示模式
  - [CocoaPlugin](https://github.com/yiyungent/KnifeHub/releases?q=CocoaPlugin&expanded=true)
    - [x] QQ 基础插件, 可依赖本插件开发相关插件, 提供模块化事件派发, 机器人管理
    - [x] 依赖 [Miyakowww/CocoaFramework2](https://github.com/Miyakowww/CocoaFramework2)
    - [x] 对接 `mirai-api-http`
    - [x] 订阅私聊/群聊
    - [x] 演示模式
  - [MoLi4QQChannelPlugin](https://github.com/yiyungent/KnifeHub/releases?q=MoLi4QQChannelPlugin&expanded=true)
    - [x] **启用前需保证 QQChannelPlugin 处于已启用状态**
    - [x] 专为 QQ 频道, 支持多个机器人 
    - [x] 对接 [茉莉机器人 API](https://mlyai.com?from=GitHub-KnifeHub)
      - 自定义知识库, 各种娱乐功能
    - [x] `@机器人` / `聊天前缀`
    - [x] 免费API调用次数：500次/天
      - 专属8折优惠码：`qqbothub`
  - [MoLiPlugin](https://github.com/yiyungent/KnifeHub/releases?q=MoLiPlugin&expanded=true)
    - [x] **启用前需保证 KonataPlugin 处于已启用状态** 
    - [x] 对接 [茉莉机器人 API](https://mlyai.com?from=GitHub-KnifeHub)
      - 自定义知识库, 各种娱乐功能
    - [x] 设置 机器人聊天群, 好友
    - [x] `@机器人` / `聊天前缀`
    - [x] 免费API调用次数：500次/天
      - 专属8折优惠码：`qqbothub`
  - [QQStatPlugin](https://github.com/yiyungent/KnifeHub/releases?q=QQStatPlugin&expanded=true)
    - [x] **启用前需保证 KonataPlugin 处于已启用状态** 
    - [x] 收集群聊消息 
    - [x] 下载 群聊 数据库
    - [x] `#日历`
    - [x] `#折线`
  - [AutoLoginPlugin](https://github.com/yiyungent/KnifeHub/releases?q=AutoLoginPlugin&expanded=true) 
    - [x] **启用前需保证 KonataPlugin 处于已启用状态** 
    - [x] 定时 检测在线状态 (频率:1分钟)
    - [x] 当由于异常离线后, 自动利用登录成功的数据 重新登录
    - [x] 重新登录成功后, 通知 `AdminQQ`
  - [QQNotePlugin](https://github.com/yiyungent/KnifeHub/releases?q=QQNotePlugin&expanded=true) 
    - [x] **启用前需保证 KonataPlugin 处于已启用状态** 
    - [x] 利用 QQ 写笔记 (随笔/零碎知识点)
      - 笔记写入 GitHub 指定仓库的指定文件中
  - [ZhiDaoPlugin](https://github.com/yiyungent/KnifeHub/releases?q=ZhiDaoPlugin&expanded=true) 
    - [x] **启用前需保证 KonataPlugin 处于已启用状态**  
    - [x] 自定义问答
      - [x] 群主/管理员/AdminQQ 自定义问答
      - [x] 分群自定义问答    
      - [x] 关键词自动回复 
  - [QQHelloWorldPlugin](https://github.com/yiyungent/KnifeHub/releases?q=QQHelloWorldPlugin&expanded=true)
    - [x] **启用前需保证 KonataPlugin 处于已启用状态**  
    - [x] 复读好友私聊
    - [x] 上下线通知 设置 里的 AdminQQ
  - [BackupPlugin](https://github.com/yiyungent/KnifeHub/releases?q=BackupPlugin&expanded=true) 
    - [x] 定时 自动 备份 插件数据
    - [x] 将 备份文件 发送到 Telegram 
    - 备份时消耗较大, 建议 搭配 `AutoLoginPlugin` 使用, 防止备份途中 意外掉线

## Screenshots

![PluginCore Admin](./screenshots/PluginCore-Admin.png)

![qq_online.png](./screenshots/qq_online.png)

### [QQStatPlugin](https://github.com/yiyungent/KnifeHub/releases?q=QQStatPlugin&expanded=true)

![](./screenshots/2022-04-18-15-46-04.png)
![](./screenshots/2022-04-18-15-47-02.png)

## Quick Start

### 部署

> `PluginCore Admin 用户名` 与 `PluginCore Admin 密码` 为你自己设置的后台登录用户名与密码, 随意设置即可, 自己记住就行

#### 方式1：原生部署 (适合小白)

> [Releases - KnifeHub, 点我下载](https://github.com/yiyungent/KnifeHub/releases?q=KnifeHub&expanded=true)         
> 找到并下载 **KnifeHub** 相应平台压缩包,       
> (Windows 系统 一般下载 Windows-64 版本即可, 即 **KnifeHub-win-x64.zip**)   
> 解压里面有 **KnifeHub.Web.exe** , 运行它即可 (无需再安装其它任何运行库)    
> 黑窗口中会显示一个 url 地址（Now listening on:后跟随的地址）, 复制到浏览器中打开即可 
> 保持此黑窗口在后台运行即可


#### 方式2: 使用 Render 免费 一键部署 

> - 点击下方按钮 一键部署        
> - 免费注册, 无需信用卡验证      
> - Free Instance Hours: 750 hours/month
> - Free Bandwidth: 100 GB/month
> - Free Build Minutes: 500 min/month

<!-- [![Deploy to Render](http://render.com/images/deploy-to-render-button.svg)](https://render.com/deploy?repo=https://github.com/yiyungent/KnifeHub) -->
[![Deploy to Render](http://render.com/images/deploy-to-render-button.svg)](https://yourls.yiyungent.eu.org/knifehubdeployrender)

##### Render 环境变量

| 环境变量名称                | 必填 | 备注                    |
| --------------------------- | ---- | ----------------------- |
| `PLUGINCORE_ADMIN_USERNAME` | √    | PluginCore Admin 用户名 |
| `PLUGINCORE_ADMIN_PASSWORD` | √    | PluginCore Admin 密码   |

#### 方式3: 使用 Railway 免费 一键部署 

> - 点击下方按钮 一键部署        
> - 免费注册, 无需信用卡验证      
> - 每月 `$5.00` 免费额度 / 每月 500 小时免费执行时间

[![Deploy on Railway](https://railway.app/button.svg)](https://railway.app/new/template/A3JY-J?referralCode=8eKBDA)


##### Railway 环境变量

| 环境变量名称                | 必填 | 备注                    |
| --------------------------- | ---- | ----------------------- |
| `PLUGINCORE_ADMIN_USERNAME` | √    | PluginCore Admin 用户名 |
| `PLUGINCORE_ADMIN_PASSWORD` | √    | PluginCore Admin 密码   |


> 注意:    
> - Railway 修改环境变量 会 触发 重新 Deploy   
> - Railway 重新 Deploy 后会删除数据, 你安装的所有插件及数据都将清空。

#### 方式4: 使用 Heroku 一键部署 

> 注意：此种方式可能无法 KonataPlugin: QQ登录

> - 点击下方按钮 一键部署       
> - Heroku 应用一段时间不访问会自动休眠, 因此为了保证存活, 请使用第三方监控保活, 例如: [UptimeRobot: 免费网站监控服务](https://uptimerobot.com/)   

<!-- [![Deploy on Heroku](https://www.herokucdn.com/deploy/button.svg)](https://heroku.com/deploy?template=https://github.com/yiyungent/KnifeHub) -->
[![Deploy on Heroku](https://www.herokucdn.com/deploy/button.svg)](https://yourls.yiyungent.eu.org/knifehubdeployheroku)



##### Heroku 环境变量

| 环境变量名称                | 必填 | 备注                    |
| --------------------------- | ---- | ----------------------- |
| `PLUGINCORE_ADMIN_USERNAME` | √    | PluginCore Admin 用户名 |
| `PLUGINCORE_ADMIN_PASSWORD` | √    | PluginCore Admin 密码   |




#### 方式5: 使用 Docker

```bash
docker run -d -p 5004:80 -e ASPNETCORE_URLS="http://*:80" -e ASPNETCORE_ENVIRONMENT="Production" -e TZ="Asia/Shanghai"  --name knifehub yiyungent/knifehub
```

```bash
# 可选, 进入容器 管理, 例如修改 /app/App_Data/PluginCore.Config.json 中的 PluginCore Admin 用户名与密码
docker exec -it knifehub bash
```

> 现在访问: <http://your-domain/PluginCore/Admin>  your-domain 为黑窗口中显示的 url 地址



### KonataPlugin: QQ 登录

> 部署完成后
> > ⭐⭐⭐⭐ 一定要先登录 `PluginCore Admin`, 因为 `QQ登录页面` 与 `PluginCore Admin` 使用相同权限⭐⭐⭐⭐      
> > 访问 **401** 说明你没有登录 <https://your-domain/PluginCore/Admin>      
> 1. 访问: <https://your-domain/PluginCore/Admin>  进入 `PluginCore Admin` 在插件列表中添加[KonataPlugin插件](https://github.com/yiyungent/KnifeHub/releases?q=KonataPlugin&expanded=true)
> 2. 访问: <https://your-domain/Plugins/KonataPlugin> 进行 QQ机器人 登录

> 若为 `短信验证` , 则直接输入收到的验证码, 点击 `提交验证` 即可

> 若为 `滑动验证` , 则 `点击前往验证`, 浏览器在 `滑动验证` 页面 按 `F12`, 再选择 `Network`, 通过滑动验证后, 复制 `ticket` 如下 (不要包括双引号), 将 `ticket` 粘贴到输入框, 点击 `提交验证` 即可

![login_slide.png](./screenshots/login_slide.png)

> 注意验证不要等待太久, 否则尝试刷新登录页面 以重新登录及获取新验证


> **注意**    
> ⭐⭐⭐⭐当 **无法登录** 时⭐⭐⭐⭐
> 
> - 当 `滑动验证` `验证通过` 后, 等待一会 , 还是 `无法进入已登录状态`     
>   
> 可 下载 [Releases - KonataApp - Assets](https://github.com/yiyungent/KnifeHub/releases?q=KonataApp&expanded=true) 在本地登录成功后,    
> 获取 **BotKeyStore.json** 后, 在登录页面使用 **配置** 方式登录
> 
> > - 大部分人电脑为 `Windows 64 位`, 点击 **KonataApp-win-x64.zip** 下载即可, 下载到本地解压, 双击 **KonataApp.exe**
> > - 运行 `KonataApp.exe` 会自动给出输入提示, 按提示操作即可       
> > - 运行 `KonataApp.exe` 无需额外安装 `.NET SDK 或 Runtime`, 程序已打包





### 插件管理

访问: <https://your-domain/PluginCore/Admin>  进入 `PluginCore Admin`

> 插件:   
> 下载插件包, 
> > 插件包下载见 [Release](https://github.com/yiyungent/KnifeHub/releases) , 
> > 直接插件上传 下载的 `QQHelloWorldPlugin-net6.0.zip` 即可    
> 
> 然后直接 `上传 -> 安装 -> 文档 -> 设置 -> 启用 -> 文档` 即可


## 更新 KnifeHub

> 查看最新版 [Releases - KnifeHub](https://github.com/yiyungent/KnifeHub/releases?q=KnifeHub&expanded=true)


> 若你使用 `Railway` 一键部署,         
> 只需要修改 `Railway` 创建的仓库 (例如: `KnifeHub`) 里的 `Dockerfile` 文件里的 `yiyungent/knifehub:v0.5.2` , 更新最后的版本号 `v0.5.2` 到最新版即可


> **注意:**    
> 请更新前导出插件数据, `QQStatPlugin` 支持下载数据库到本地, 然后下载最新插件包, 解压, 将数据库文件替换为你导出的数据库文件, 然后在有 `QQStatPlugin.sqlite` 的路径下打包所有文件 为 zip, 上传插件即可           
> `插件设置` 可以通过保持打开插件设置页面的方式, 重新安装插件后, 再在此页面点击保存


> 一些更新 docker knifehub 可能需要用到的命令

```bash
cd /www/wwwroot/knifehub*
# docker-data 位置用于保存当前容器数据
mkdir -p docker-data/App_Data/
mkdir -p docker-data/Plugins/
mkdir -p docker-data/Plugins_wwwroot/
# 保存当前数据
docker cp knifehub:/app/App_Data/PluginCore.Config.json docker-data/App_Data/PluginCore.Config.json
docker cp knifehub:/app/App_Data/plugin.config.json docker-data/App_Data/plugin.config.json
docker cp knifehub:/app/Plugins/ docker-data/
docker cp knifehub:/app/Plugins_wwwroot/ docker-data/

# 移除当前
docker stop knifehub
docker rm knifehub
docker rmi yiyungent/knifehub

# 获取最新
# 建议不要使用 latest , 而是指定最新的版本号, 有可能你使用的 docker 仓储源还未同步, 而导致 latest 仍为旧版
#docker pull yiyungent/knifehub:v1.0.0
docker pull yiyungent/knifehub:latest
docker run -d -p 53213:80 -e ASPNETCORE_URLS="http://*:80" -e ASPNETCORE_ENVIRONMENT="Production" -e TZ="Asia/Shanghai"  --name knifehub yiyungent/knifehub

# 这里我将原本备份的数据保存到了这个路径, 进入这个路径, 将备份数据覆盖到 docker 容器中
cd docker-data

docker cp App_Data/PluginCore.Config.json knifehub:/app/App_Data/PluginCore.Config.json
docker cp App_Data/plugin.config.json knifehub:/app/App_Data/plugin.config.json
docker cp Plugins/ knifehub:/app/
docker cp Plugins_wwwroot/ knifehub:/app/

# 重启容器
docker restart knifehub
```



## 插件开发

> 注意:  
> 所有纯基于 `PluginCore.IPlugins` 开发的插件都通用,   
> 下载插件包, 然后 `上传 -> 安装 -> 设置 -> 启用` 即可


> 插件开发 可参考:   
> - [插件开发 | PluginCore](https://moeci.com/PluginCore/zh/PluginDev/Guide/)      
> - **建议** 参考: [./plugins/QQHelloWorldPlugin](https://github.com/yiyungent/KnifeHub/tree/main/plugins/QQHelloWorldPlugin)

> KnifeHub 插件开发包  
> 插件开发包中已包含:   
> - `PluginCore.IPlugins.AspNetCore`

> 注意: 如果你不需要 `KnifeHub.Sdk` 中的一些 `Utils` , 那么建议直接依赖 `PluginCore.IPlugins.AspNetCore` , 减少依赖项, 使之称为通用插件

```powershell
dotnet add package KnifeHub.Sdk
```

> **注意**:   
> - 本项目目前直接使用的 `PluginCore` 插件框架, 插件采用激发式, 插件工作完成后, 实例会立即销毁, 无法常驻后台
> - 若需要定时任务, 可以使用 `ITimeJobPlugin`, 可见 `PluginCore` 的文档    
> - 由于 QQBot 本身为常驻, 因此需额外注意 `IPluginFinder` 的服务的生命周期/范围, 这点和在 `ASP.NET Core` 的 `Controller` 中 直接使用不同

## 相关项目

- [KonataDev/Konata.Core](https://github.com/KonataDev/Konata.Core) - QQ Android 协议核心库
- [Chianne1025/QQChannelFramework](https://github.com/Chianne1025/QQChannelFramework) - QQ 频道 核心库
- [yiyungent/PluginCore](https://github.com/yiyungent/PluginCore) - 插件系统

### 社区插件

> 欢迎 Pull Request !

- [SweelLong/AntiRecall: 这是基于KnifeHub - KonataPlugin的开源插件，功能是防止消息撤回。](https://github.com/SweelLong/AntiRecall)       
- [SweelLong/RandomImage: 这是基于QQBotHub的开源插件，主要功能是发送随机图片。（短期内不会更新）](https://github.com/SweelLong/RandomImage)       


## 赞助者

本列表由 [afdian-action](https://github.com/yiyungent/afdian-action) 自动更新

感谢这些来自爱发电的赞助者：

<!-- AFDIAN-ACTION:START -->

<a href="https://afdian.net/u/459023b8e07b11eb92af52540025c377">
    <img src="https://pic1.afdiancdn.com/user/459023b8e07b11eb92af52540025c377/avatar/9238a84b58fdc0aa6093340709d63fd4_w1500_h925_s935.jpg?imageView2/1/w/120/h/120" width="40" height="40" alt="Dr" title="Dr"/>
</a>
<a href="https://afdian.net/u/6c944aa0a55f11eabd5f52540025c377">
    <img src="https://pic1.afdiancdn.com/user/6c944aa0a55f11eabd5f52540025c377/avatar/e0b9977363fe0b475e0fb6300c43b4be_w480_h480_s13.jpg?imageView2/1/w/120/h/120" width="40" height="40" alt="MonoLogueChi" title="MonoLogueChi"/>
</a>

<details>
  <summary>点我 打开/关闭 赞助者列表</summary>

<a href="https://afdian.net/u/459023b8e07b11eb92af52540025c377">
Dr
</a>
<span>( 1 次赞助, 共 ￥10 ) 留言: 非常感谢</span><br>
<a href="https://afdian.net/u/6c944aa0a55f11eabd5f52540025c377">
MonoLogueChi
</a>
<span>( 1 次赞助, 共 ￥28.2 ) 留言: 感谢你的开源项目</span><br>

</details>
<!-- 注意: 尽量将标签前靠,否则经测试可能被 GitHub 解析为代码块 -->
<!-- AFDIAN-ACTION:END -->


## Donate

KnifeHub is an Apache-2.0 licensed open source project and completely free to use. However, the amount of effort needed to maintain and develop new features for the project is not sustainable without proper financial backing.

We accept donations through these channels:

- <a href="https://afdian.net/@yiyun" target="_blank">爱发电</a> (￥5.00 起)
- <a href="https://dun.mianbaoduo.com/@yiyun" target="_blank">面包多</a> (￥1.00 起)

## Author

- KnifeHub.Web `Apache-2.0`
- KnifeHub.Sdk `Apache-2.0`
- QQHelloWorldPlugin `GPL-3.0`
- MoLiPlugin `GPL-3.0`
- QQStatPlugin `GPL-3.0`
- BackupPlugin `MIT`
- AutoLoginPlugin `GPL-3.0`
- QQNotePlugin `GPL-3.0`
- ZhiDaoPlugin `GPL-3.0`
- WebMonitorPlugin `Apache-2.0`
- QQChannelPlugin `MIT`
- MoLi4QQChannelPlugin `MIT`

**KnifeHub** © [yiyun](https://github.com/yiyungent), Released under the [GPL-3.0](./LICENSE) License.<br>
Authored and maintained by yiyun with help from contributors ([list](https://github.com/yiyungent/KnifeHub/contributors)).

> GitHub [@yiyungent](https://github.com/yiyungent) Gitee [@yiyungent](https://gitee.com/yiyungent)

<!-- Matomo Image Tracker-->
<img referrerpolicy="no-referrer-when-downgrade" src="https://matomo.moeci.com/matomo.php?idsite=2&amp;rec=1&amp;action_name=GitHub.KnifeHub.README" style="border:0" alt="" />
<!-- End Matomo -->
