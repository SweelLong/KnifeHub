# fly.io Dockerfile

FROM yiyungent/knifehub:v1.0.5

ADD flyio-entrypoint.sh ./flyio-entrypoint.sh
RUN chmod +x ./flyio-entrypoint.sh
ADD flyio-PluginCore.Config.json ./flyio-PluginCore.Config.json

ENTRYPOINT ["/bin/sh", "./flyio-entrypoint.sh"]