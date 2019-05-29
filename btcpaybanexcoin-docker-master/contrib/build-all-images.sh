#!/bin/bash

# This file is automatically generated by the DockerFileBuildHelper tool, run DockerFileBuildHelper/update-repo.sh to update it
set -e
DOCKERFILE=""


# Build docker-compose-generator
# https://raw.githubusercontent.com/btcpayserver/btcpayserver-docker/dcg-latest/docker-compose-generator/linuxamd64.Dockerfile
DOCKERFILE="docker-compose-generator/linuxamd64.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/btcpayserver-docker/dcg-latest/docker-compose-generator/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="docker-compose-generator/linuxarm32v7.Dockerfile"
echo "Building btcpayserver/docker-compose-generator:latest"
git clone https://github.com/btcpayserver/btcpayserver-docker docker-compose-generator
cd docker-compose-generator
git checkout dcg-latest
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/docker-compose-generator:latest" .
cd - && cd ..


# Build docker-compose-builder
DOCKERFILE=""
# https://raw.githubusercontent.com/btcpayserver/docker-compose-builder/v1.23.2/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="linuxarm32v7.Dockerfile"
if [[ "$DOCKERFILE" ]]; then
	echo "Building btcpayserver/docker-compose-builder:1.23.2"
	git clone https://github.com/btcpayserver/docker-compose-builder docker-compose-builder
	cd docker-compose-builder
	git checkout v1.23.2
	cd "$(dirname $DOCKERFILE)"
	docker build -f "$DOCKERFILE" -t "btcpayserver/docker-compose-builder:1.23.2" .
	cd - && cd ..
fi


# Build btglnd
# https://raw.githubusercontent.com/vutov/lnd/master/BTCPayServer.Dockerfile
DOCKERFILE="BTCPayServer.Dockerfile"
echo "Building kamigawabul/btglnd:latest"
git clone https://github.com/vutov/lnd btglnd
cd btglnd
git checkout master
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "kamigawabul/btglnd:latest" .
cd - && cd ..


# Build docker-bitcoingold
# https://raw.githubusercontent.com/Vutov/docker-bitcoin/master/bitcoingold/0.15.2/Dockerfile
DOCKERFILE="bitcoingold/0.15.2/Dockerfile"
echo "Building kamigawabul/docker-bitcoingold:0.15.2"
git clone https://github.com/Vutov/docker-bitcoin docker-bitcoingold
cd docker-bitcoingold
git checkout master
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "kamigawabul/docker-bitcoingold:0.15.2" .
cd - && cd ..


# Build lightning
# https://raw.githubusercontent.com/btcpayserver/lightning/basedon-v0.7.0-3/Dockerfile
DOCKERFILE="Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/lightning/basedon-v0.7.0-3/contrib/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="contrib/linuxarm32v7.Dockerfile"
echo "Building btcpayserver/lightning:v0.7.0-3"
git clone https://github.com/btcpayserver/lightning lightning
cd lightning
git checkout basedon-v0.7.0-3
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/lightning:v0.7.0-3" .
cd - && cd ..


# Build lightning-charge
# https://raw.githubusercontent.com/ElementsProject/lightning-charge/v0.4.6/Dockerfile
DOCKERFILE="Dockerfile"
echo "Building shesek/lightning-charge:0.4.6-standalone"
git clone https://github.com/ElementsProject/lightning-charge lightning-charge
cd lightning-charge
git checkout v0.4.6
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "shesek/lightning-charge:0.4.6-standalone" .
cd - && cd ..


# Build spark-wallet
# https://raw.githubusercontent.com/shesek/spark-wallet/v0.2.4/Dockerfile
DOCKERFILE="Dockerfile"
echo "Building shesek/spark-wallet:0.2.4-standalone"
git clone https://github.com/shesek/spark-wallet spark-wallet
cd spark-wallet
git checkout v0.2.4
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "shesek/spark-wallet:0.2.4-standalone" .
cd - && cd ..


# Build lnd
# https://raw.githubusercontent.com/btcpayserver/lnd/basedon-v0.6.1-beta/linuxamd64.Dockerfile
DOCKERFILE="linuxamd64.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/lnd/basedon-v0.6.1-beta/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="linuxarm32v7.Dockerfile"
echo "Building btcpayserver/lnd:v0.6.1-beta"
git clone https://github.com/btcpayserver/lnd lnd
cd lnd
git checkout basedon-v0.6.1-beta
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/lnd:v0.6.1-beta" .
cd - && cd ..


# Build rtl
# https://raw.githubusercontent.com/ShahanaFarooqui/RTL/v0.3.2/Dockerfile
DOCKERFILE="Dockerfile"
# https://raw.githubusercontent.com/ShahanaFarooqui/RTL/v0.3.2/Dockerfile.arm32v7
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="Dockerfile.arm32v7"
echo "Building shahanafarooqui/rtl:0.3.2"
git clone https://github.com/ShahanaFarooqui/RTL rtl
cd rtl
git checkout v0.3.2
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "shahanafarooqui/rtl:0.3.2" .
cd - && cd ..


# Build bitcoin
# https://raw.githubusercontent.com/btcpayserver/dockerfile-deps/Bitcoin/0.18.0/Bitcoin/0.18.0/linuxamd64.Dockerfile
DOCKERFILE="Bitcoin/0.18.0/linuxamd64.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/dockerfile-deps/Bitcoin/0.18.0/Bitcoin/0.18.0/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="Bitcoin/0.18.0/linuxarm32v7.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/dockerfile-deps/Bitcoin/0.18.0/Bitcoin/0.18.0/linuxarm64v8.Dockerfile
[[ "$(uname -m)" == "aarch64" ]] && DOCKERFILE="Bitcoin/0.18.0/linuxarm64v8.Dockerfile"
echo "Building btcpayserver/bitcoin:0.18.0"
git clone https://github.com/btcpayserver/dockerfile-deps bitcoin
cd bitcoin
git checkout Bitcoin/0.18.0
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/bitcoin:0.18.0" .
cd - && cd ..


# Build docker-bitcoinplus
# https://raw.githubusercontent.com/ChekaZ/docker/master/bitcoinplus/2.7.0/Dockerfile
DOCKERFILE="bitcoinplus/2.7.0/Dockerfile"
echo "Building chekaz/docker-bitcoinplus:2.7.0"
git clone https://github.com/ChekaZ/docker docker-bitcoinplus
cd docker-bitcoinplus
git checkout master
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "chekaz/docker-bitcoinplus:2.7.0" .
cd - && cd ..


# Build docker-bitcore
# https://raw.githubusercontent.com/dalijolijo/btcpayserver-docker-bitcore/master/btx-debian/Dockerfile
DOCKERFILE="btx-debian/Dockerfile"
echo "Building dalijolijo/docker-bitcore:0.15.2"
git clone https://github.com/dalijolijo/btcpayserver-docker-bitcore docker-bitcore
cd docker-bitcore
git checkout master
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "dalijolijo/docker-bitcore:0.15.2" .
cd - && cd ..


# Build btcpayserver
# https://raw.githubusercontent.com/btcpayserver/btcpayserver/v1.0.3.105/Dockerfile.linuxamd64
DOCKERFILE="Dockerfile.linuxamd64"
# https://raw.githubusercontent.com/btcpayserver/btcpayserver/v1.0.3.105/Dockerfile.linuxarm32v7
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="Dockerfile.linuxarm32v7"
echo "Building btcpayserver/btcpayserver:1.0.3.105"
git clone https://github.com/btcpayserver/btcpayserver btcpayserver
cd btcpayserver
git checkout v1.0.3.105
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/btcpayserver:1.0.3.105" .
cd - && cd ..


# Build dash
# https://raw.githubusercontent.com/btcpayserver/dockerfile-deps/Dash/0.13.0/Dash/0.13.0/linuxamd64.Dockerfile
DOCKERFILE="Dash/0.13.0/linuxamd64.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/dockerfile-deps/Dash/0.13.0/Dash/0.13.0/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="Dash/0.13.0/linuxarm32v7.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/dockerfile-deps/Dash/0.13.0/Dash/0.13.0/linuxarm64v8.Dockerfile
[[ "$(uname -m)" == "aarch64" ]] && DOCKERFILE="Dash/0.13.0/linuxarm64v8.Dockerfile"
echo "Building btcpayserver/dash:0.13.0"
git clone https://github.com/btcpayserver/dockerfile-deps dash
cd dash
git checkout Dash/0.13.0
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/dash:0.13.0" .
cd - && cd ..


# Build dogecoin
# https://raw.githubusercontent.com/rockstardev/docker-bitcoin/feature/dogecoin/dogecoin/1.10.0/Dockerfile
DOCKERFILE="dogecoin/1.10.0/Dockerfile"
echo "Building rockstardev/dogecoin:1.10.0"
git clone https://github.com/rockstardev/docker-bitcoin dogecoin
cd dogecoin
git checkout feature/dogecoin
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "rockstardev/dogecoin:1.10.0" .
cd - && cd ..


# Build docker-feathercoin
# https://raw.githubusercontent.com/ChekaZ/docker/master/feathercoin/0.16.3/Dockerfile
DOCKERFILE="feathercoin/0.16.3/Dockerfile"
echo "Building chekaz/docker-feathercoin:0.16.3"
git clone https://github.com/ChekaZ/docker docker-feathercoin
cd docker-feathercoin
git checkout master
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "chekaz/docker-feathercoin:0.16.3" .
cd - && cd ..


# Build lightning
# https://raw.githubusercontent.com/Groestlcoin/lightning/v0.7.0/Dockerfile
DOCKERFILE="Dockerfile"
echo "Building groestlcoin/lightning:v0.7.0"
git clone https://github.com/Groestlcoin/lightning lightning
cd lightning
git checkout v0.7.0
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "groestlcoin/lightning:v0.7.0" .
cd - && cd ..


# Build groestlcoin-lightning-charge
# https://raw.githubusercontent.com/Groestlcoin/groestlcoin-lightning-charge/v0.4.7/Dockerfile
DOCKERFILE="Dockerfile"
echo "Building groestlcoin/groestlcoin-lightning-charge:version-0.4.7"
git clone https://github.com/Groestlcoin/groestlcoin-lightning-charge groestlcoin-lightning-charge
cd groestlcoin-lightning-charge
git checkout v0.4.7
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "groestlcoin/groestlcoin-lightning-charge:version-0.4.7" .
cd - && cd ..


# Build groestlcoin-spark
# https://raw.githubusercontent.com/Groestlcoin/groestlcoin-spark/v0.2.4/Dockerfile
DOCKERFILE="Dockerfile"
echo "Building groestlcoin/groestlcoin-spark:version-0.2.4"
git clone https://github.com/Groestlcoin/groestlcoin-spark groestlcoin-spark
cd groestlcoin-spark
git checkout v0.2.4
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "groestlcoin/groestlcoin-spark:version-0.2.4" .
cd - && cd ..


# Build docker-groestlcoin
# https://raw.githubusercontent.com/NicolasDorier/docker-bitcoin/master/groestlcoin/2.17.2/Dockerfile
DOCKERFILE="groestlcoin/2.17.2/Dockerfile"
echo "Building nicolasdorier/docker-groestlcoin:2.17.2"
git clone https://github.com/NicolasDorier/docker-bitcoin docker-groestlcoin
cd docker-groestlcoin
git checkout master
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "nicolasdorier/docker-groestlcoin:2.17.2" .
cd - && cd ..


# Build lightning
# https://raw.githubusercontent.com/btcpayserver/lightning/basedon-v0.7.0-3/Dockerfile
DOCKERFILE="Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/lightning/basedon-v0.7.0-3/contrib/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="contrib/linuxarm32v7.Dockerfile"
echo "Building btcpayserver/lightning:v0.7.0-3"
git clone https://github.com/btcpayserver/lightning lightning
cd lightning
git checkout basedon-v0.7.0-3
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/lightning:v0.7.0-3" .
cd - && cd ..


# Build lnd
# https://raw.githubusercontent.com/btcpayserver/lnd/basedon-v0.6-beta/linuxamd64.Dockerfile
DOCKERFILE="linuxamd64.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/lnd/basedon-v0.6-beta/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="linuxarm32v7.Dockerfile"
echo "Building btcpayserver/lnd:v0.6-beta"
git clone https://github.com/btcpayserver/lnd lnd
cd lnd
git checkout basedon-v0.6-beta
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/lnd:v0.6-beta" .
cd - && cd ..


# Build litecoin
# https://raw.githubusercontent.com/btcpayserver/dockerfile-deps/Litecoin/0.17.1-1/Litecoin/0.17.1/linuxamd64.Dockerfile
DOCKERFILE="Litecoin/0.17.1/linuxamd64.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/dockerfile-deps/Litecoin/0.17.1-1/Litecoin/0.17.1/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="Litecoin/0.17.1/linuxarm32v7.Dockerfile"
echo "Building btcpayserver/litecoin:0.17.1-1"
git clone https://github.com/btcpayserver/dockerfile-deps litecoin
cd litecoin
git checkout Litecoin/0.17.1-1
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/litecoin:0.17.1-1" .
cd - && cd ..


# Build docker-monacoin
# https://raw.githubusercontent.com/wakiyamap/docker-bitcoin/master/monacoin/0.16.3/Dockerfile
DOCKERFILE="monacoin/0.16.3/Dockerfile"
echo "Building wakiyamap/docker-monacoin:0.16.3"
git clone https://github.com/wakiyamap/docker-bitcoin docker-monacoin
cd docker-monacoin
git checkout master
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "wakiyamap/docker-monacoin:0.16.3" .
cd - && cd ..


# Build nbxplorer
# https://raw.githubusercontent.com/dgarage/nbxplorer/v2.0.0.45/Dockerfile.linuxamd64
DOCKERFILE="Dockerfile.linuxamd64"
# https://raw.githubusercontent.com/dgarage/nbxplorer/v2.0.0.45/Dockerfile.linuxarm32v7
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="Dockerfile.linuxarm32v7"
echo "Building nicolasdorier/nbxplorer:2.0.0.45"
git clone https://github.com/dgarage/nbxplorer nbxplorer
cd nbxplorer
git checkout v2.0.0.45
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "nicolasdorier/nbxplorer:2.0.0.45" .
cd - && cd ..


# Build nginx
# https://raw.githubusercontent.com/nginxinc/docker-nginx/master/stable/stretch/Dockerfile
DOCKERFILE="stable/stretch/Dockerfile"
# https://raw.githubusercontent.com/nginxinc/docker-nginx/master/stable/stretch/Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="stable/stretch/Dockerfile"
echo "Building nginx:latest"
git clone https://github.com/nginxinc/docker-nginx nginx
cd nginx
git checkout master
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "nginx:latest" .
cd - && cd ..


# Build docker-gen
# https://raw.githubusercontent.com/btcpayserver/docker-gen/v0.7.5/linuxamd64.Dockerfile
DOCKERFILE="linuxamd64.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/docker-gen/v0.7.5/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="linuxarm32v7.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/docker-gen/v0.7.5/linuxarm64v8.Dockerfile
[[ "$(uname -m)" == "aarch64" ]] && DOCKERFILE="linuxarm64v8.Dockerfile"
echo "Building btcpayserver/docker-gen:0.7.5"
git clone https://github.com/btcpayserver/docker-gen docker-gen
cd docker-gen
git checkout v0.7.5
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/docker-gen:0.7.5" .
cd - && cd ..


# Build letsencrypt-nginx-proxy-companion
# https://raw.githubusercontent.com/btcpayserver/docker-letsencrypt-nginx-proxy-companion/v1.10.0/linuxamd64.Dockerfile
DOCKERFILE="linuxamd64.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/docker-letsencrypt-nginx-proxy-companion/v1.10.0/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="linuxarm32v7.Dockerfile"
echo "Building btcpayserver/letsencrypt-nginx-proxy-companion:1.10.0"
git clone https://github.com/btcpayserver/docker-letsencrypt-nginx-proxy-companion letsencrypt-nginx-proxy-companion
cd letsencrypt-nginx-proxy-companion
git checkout v1.10.0
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/letsencrypt-nginx-proxy-companion:1.10.0" .
cd - && cd ..


# Build btcqbo
# https://raw.githubusercontent.com/JeffVandrewJr/btcqbo/v0.3.32/Dockerfile
DOCKERFILE="Dockerfile"
echo "Building jvandrew/btcqbo:0.3.32"
git clone https://github.com/JeffVandrewJr/btcqbo btcqbo
cd btcqbo
git checkout v0.3.32
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "jvandrew/btcqbo:0.3.32" .
cd - && cd ..


# Build redis
# https://raw.githubusercontent.com/docker-library/redis/f1a8498333ae3ab340b5b39fbac1d7e1dc0d628c/5.0/Dockerfile
DOCKERFILE="5.0/Dockerfile"
echo "Building redis:5.0.2-alpine"
git clone https://github.com/docker-library/redis redis
cd redis
git checkout f1a8498333ae3ab340b5b39fbac1d7e1dc0d628c
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "redis:5.0.2-alpine" .
cd - && cd ..


# Build btctransmuter
# https://raw.githubusercontent.com/btcpayserver/btctransmuter/v0.0.19/BtcTransmuter/Dockerfile.linuxamd64
DOCKERFILE="BtcTransmuter/Dockerfile.linuxamd64"
# https://raw.githubusercontent.com/btcpayserver/btctransmuter/v0.0.19/BtcTransmuter/Dockerfile.linuxarm32v7
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="BtcTransmuter/Dockerfile.linuxarm32v7"
echo "Building btcpayserver/btctransmuter:0.0.19"
git clone https://github.com/btcpayserver/btctransmuter btctransmuter
cd btctransmuter
git checkout v0.0.19
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/btctransmuter:0.0.19" .
cd - && cd ..


# Build librepatron
# https://raw.githubusercontent.com/JeffVandrewJr/patron/v0.7.37/Dockerfile
DOCKERFILE="Dockerfile"
echo "Building jvandrew/librepatron:0.7.37"
git clone https://github.com/JeffVandrewJr/patron librepatron
cd librepatron
git checkout v0.7.37
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "jvandrew/librepatron:0.7.37" .
cd - && cd ..


# Build isso
# https://raw.githubusercontent.com/JeffVandrewJr/isso/patron.22/Dockerfile
DOCKERFILE="Dockerfile"
echo "Building jvandrew/isso:atron.22"
git clone https://github.com/JeffVandrewJr/isso isso
cd isso
git checkout patron.22
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "jvandrew/isso:atron.22" .
cd - && cd ..


# Build tor
# https://raw.githubusercontent.com/btcpayserver/dockerfile-deps/Tor/0.3.5.8/Tor/0.3.5.8/linuxamd64.Dockerfile
DOCKERFILE="Tor/0.3.5.8/linuxamd64.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/dockerfile-deps/Tor/0.3.5.8/Tor/0.3.5.8/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="Tor/0.3.5.8/linuxarm32v7.Dockerfile"
echo "Building btcpayserver/tor:0.3.5.8"
git clone https://github.com/btcpayserver/dockerfile-deps tor
cd tor
git checkout Tor/0.3.5.8
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/tor:0.3.5.8" .
cd - && cd ..


# Build docker-gen
# https://raw.githubusercontent.com/btcpayserver/docker-gen/v0.7.5/linuxamd64.Dockerfile
DOCKERFILE="linuxamd64.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/docker-gen/v0.7.5/linuxarm32v7.Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="linuxarm32v7.Dockerfile"
# https://raw.githubusercontent.com/btcpayserver/docker-gen/v0.7.5/linuxarm64v8.Dockerfile
[[ "$(uname -m)" == "aarch64" ]] && DOCKERFILE="linuxarm64v8.Dockerfile"
echo "Building btcpayserver/docker-gen:0.7.5"
git clone https://github.com/btcpayserver/docker-gen docker-gen
cd docker-gen
git checkout v0.7.5
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/docker-gen:0.7.5" .
cd - && cd ..


# Build docker-woocommerce
# https://raw.githubusercontent.com/btcpayserver/docker-woocommerce/v3.0.6-3/Dockerfile
DOCKERFILE="Dockerfile"
echo "Building btcpayserver/docker-woocommerce:3.0.6-3"
git clone https://github.com/btcpayserver/docker-woocommerce docker-woocommerce
cd docker-woocommerce
git checkout v3.0.6-3
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "btcpayserver/docker-woocommerce:3.0.6-3" .
cd - && cd ..


# Build mariadb
# https://raw.githubusercontent.com/docker-library/mariadb/master/10.3/Dockerfile
DOCKERFILE="10.3/Dockerfile"
echo "Building mariadb:10.3"
git clone https://github.com/docker-library/mariadb mariadb
cd mariadb
git checkout master
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "mariadb:10.3" .
cd - && cd ..


# Build postgres
# https://raw.githubusercontent.com/docker-library/postgres/b7cb3c6eacea93be2259381033be3cc435649369/9.6/Dockerfile
DOCKERFILE="9.6/Dockerfile"
# https://raw.githubusercontent.com/docker-library/postgres/b7cb3c6eacea93be2259381033be3cc435649369/9.6/Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="9.6/Dockerfile"
echo "Building postgres:9.6.5"
git clone https://github.com/docker-library/postgres postgres
cd postgres
git checkout b7cb3c6eacea93be2259381033be3cc435649369
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "postgres:9.6.5" .
cd - && cd ..


# Build traefik
# https://raw.githubusercontent.com/containous/traefik-library-image/master/scratch/amd64/Dockerfile
DOCKERFILE="scratch/amd64/Dockerfile"
# https://raw.githubusercontent.com/containous/traefik-library-image/master/scratch/arm/Dockerfile
[[ "$(uname -m)" == "armv7l" ]] && DOCKERFILE="scratch/arm/Dockerfile"
echo "Building traefik:latest"
git clone https://github.com/containous/traefik-library-image traefik
cd traefik
git checkout master
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "traefik:latest" .
cd - && cd ..


# Build docker-trezarcoin
# https://raw.githubusercontent.com/ChekaZ/docker/master/trezarcoin/1.2.0/Dockerfile
DOCKERFILE="trezarcoin/1.2.0/Dockerfile"
echo "Building chekaz/docker-trezarcoin:0.13.0"
git clone https://github.com/ChekaZ/docker docker-trezarcoin
cd docker-trezarcoin
git checkout master
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "chekaz/docker-trezarcoin:0.13.0" .
cd - && cd ..


# Build docker-viacoin
# https://raw.githubusercontent.com/viacoin/docker-viacoin/master/viacoin/0.15.2/docker-viacoin
DOCKERFILE="viacoin/0.15.2/docker-viacoin"
echo "Building romanornr/docker-viacoin:0.15.2"
git clone https://github.com/viacoin/docker-viacoin docker-viacoin
cd docker-viacoin
git checkout master
cd "$(dirname $DOCKERFILE)"
docker build -f "$DOCKERFILE" -t "romanornr/docker-viacoin:0.15.2" .
cd - && cd ..

