# banexcoinpay
![BANEXCOINPAY](BTCPayServer/wwwroot/img/btc_pay_BG_twitter.png)

[![Docker Automated build](https://img.shields.io/docker/automated/jrottenberg/ffmpeg.svg)](https://hub.docker.com/r/nicolasdorier/btcpayserver/)
[![Deploy to Azure](https://azuredeploy.net/deploybutton.svg)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fbtcpayserver%2Fbtcpayserver-azure%2Fmaster%2Fazuredeploy.json)
[![CircleCI](https://circleci.com/gh/btcpayserver/btcpayserver.svg?style=svg)](https://circleci.com/gh/btcpayserver/btcpayserver)

# BANEXCOINPAY

## Introducción

BANEXCOINPAY es un procesador de pago de criptomoneda gratuito y de código abierto que le permite recibir pagos en Bitcoin y altcoins directamente, sin comisiones, costos de transacción o intermediarios.

BANEXCOINPAY es un sistema de facturación sin custodia que elimina la participación de un tercero. Los pagos con BANEXCOINPAY van directamente a su billetera, lo que aumenta la privacidad y la seguridad. Sus claves privadas nunca se cargan en el servidor. No se puede reutilizar la dirección, ya que cada factura genera una nueva dirección derivada de su xpubkey.

El software está integrado en C # y cumple con la factura [API de BitPay] (https://bitpay.com/api). Permite que su sitio web se pueda migrar fácilmente desde BANEXCOINPAY y que se configure como un procesador de pagos auto hospedado.

Puede ejecutar BANEXCOINPAY como una solución auto hospedada en su propio servidor, o usar un [host de terceros] (https://github.com/btcpayserver/btcpayserver-doc/blob/master/ThirdPartyHosting.md).

La solución auto hospedada le permite no solo adjuntar un número ilimitado de tiendas y usar la red Lightning, sino también convertirse en el procesador de pagos para otros.

Gracias a la [apps] (https://github.com/btcpayserver/btcpayserver-doc/blob/master/Apps.md) creada encima de ella, puede utilizar BANEXCOINPAY para recibir donaciones, iniciar una campaña de financiación colectiva o tener una en el punto de venta en la tienda.

[! [Qué es BANEXCOINPAY] (https://img.youtube.com/vi/q7xJMno_B3U/sddefault.jpg)] (https://www.youtube.com/watch?v=q7xJMno_B3U "¿Qué es BTCPay?")

## Tabla de contenido

* [Features](#features)
* [Getting Started](#getting-started)
* [Documentation](#documentation)
* [Contributing](#Contributing)
* [How to build](#how-to-build)
* [How to run](#how-to-run)
* [How to debug](#how-to-debug)
* [Dependencies](#dependencies)

## Caracteristicas

* Pagos de Bitcoin y altcoin directos, punto a punto
* Sin comisiones por transacción (aparte de las de las redes criptográficas)
* No hay tarifas de procesamiento
* No intermediario
* No KYC
* El usuario tiene control completo sobre las claves privadas
* Privacidad mejorada
* Seguridad mejorada
* Auto alojado
* Soporte SegWit
* Soporte Lightning Network (LND y c-lightning)
* Soporte de tor
* Compatibilidad total con BitPay API (migración fácil)
* Procesar pagos para terceros.
* Botones de pago fáciles de insertar
* Aplicación punto de venta.
* Aplicación de crowdfunding.
* Solicitudes de pago

## Empezando

En primer lugar, decida si desea hospedar una instancia usted mismo o use un [host de terceros] (https://docs.btcpayserver.org/deployment/thirdpartyhosting). Si ha elegido auto-hospedarse, documentamos muchas [formas de implementar BANEXCOINPAY] (https://docs.btcpayserver.org/deployment/deployment).

Después de una implementación exitosa, asegúrese de revisar nuestro [inicio] (https://docs.btcpayserver.org/btcpay-basics/gettingstarted) y [tutorial] (https://docs.btcpayserver.org/btcpay-basics/walkthrough ) guías. En caso de que desee utilizar Lightning Network, consulte [Guía de Lightning] (https://docs.btcpayserver.org/features/lightningnetwork).

## Documentación

Consulte nuestro [sitio web oficial] (https://btcpayserver.org/), nuestra [documentación completa] (https://github.com/btcpayserver/btcpayserver-doc) y [FAQ] (https: // github. com / btcpayserver / btcpayserver-doc / tree / master / FAQ # btcpay-preguntas frecuentes y preguntas frecuentes) para más detalles.

Si tiene problemas para usar BANEXCOINPAY, considere unirse a [comunidades enumeradas en el sitio web oficial] (https://btcpayserver.org/#communityCTA) para obtener ayuda de los miembros de la comunidad de BANEXCOINPAY. Solo el archivo [Github issue] (https://github.com/btcpayserver/btcpayserver/issues) para los problemas técnicos que no puede resolver a través de otros canales o solicitudes de funciones que haya validado con otros miembros de la comunidad.

El chat principal de la comunidad se encuentra en [Mattermost] (https://chat.btcpayserver.org/).

## Contribuyendo
BANEXCOINPAY está construido y mantenido en su totalidad por colaboradores voluntarios de Internet. Damos la bienvenida y apreciamos las nuevas contribuciones.

Si eres un desarrollador que está buscando ayuda, pero no estás seguro de por dónde empezar, revisa la [etiqueta de la buena primera edición] (https://github.com/btcpayserver/btcpayserver/issues?q=is%3Aissue+is % 3Aopen + label% 3A% 22good + first + issue% 22), que contiene pequeños trabajos que se han señalado específicamente como amigables para los nuevos contribuyentes.

Los contribuyentes que buscan hacer algo un poco más desafiante, antes de abrir una solicitud de extracción, [crear un problema] (https://github.com/btcpayserver/btcpayserver/issues/new/choose) o unirse a [nuestro chat de la comunidad] (https : //chat.btcpayserver.org/) para obtener retroalimentación temprana, discutir las mejores maneras de abordar el problema y asegurar que no haya duplicación de trabajos.

También tienes un video impresionante de nuestros colaboradores que te explica cómo comenzar.

[! [Rockstar Dev y Britt Kelly - Btc Pay Server Code Along] (https://img.youtube.com/vi/ZePbMPSIvHM/sddefault.jpg)] (https://www.youtube.com/embed/VNMnd- dX9Q8)

## Cómo construir

Si bien la documentación aconseja utilizar la función docker-compose, es posible que desee compilar BANEXCOINPAY usted mismo.

Primero instale .NET Core SDK v2.1.9 como lo especifica [sitio web de Microsoft] (https://www.microsoft.com/net/download/dotnet-core/2.1).

En Powershell:
`` `
. \ build.ps1
`` `

En linux:
`` `
./build.sh
`` `

## Como correr

Use los scripts `run` para ejecutar BTCPayServer, este ejemplo muestra cómo imprimir los argumentos de línea de comandos disponibles de BANEXCOINPAY.

En Powershell:
`` `
. \ run.ps1 --help
`` `

En linux:
`` `
./run.sh --help
`` `

## Cómo depurar

Si desea depurar, use Visual Studio Code o Visual Studio 2017.

Debe ejecutar la ventana acoplable de tiempo de desarrollo como se describe [en la guía de prueba] (BTCPayServer.Tests / README.md).

Luego puede ejecutar el depurador utilizando el perfil de inicio `Docker-Regtest` en Visual Studio Code o Visual Studio 2017.

Si necesita depurar la interacción de la cartera del libro mayor, instale el certificado de tiempo de desarrollo con:

`` `bash
# Instalar certificado de tiempo de desarrollo en el almacén de confianza.
dotnet dev-certs https --trust
`` `

Luego use el perfil de depuración `Docker-Regtest-https`.

## Otras dependencias

Para obtener más información, consulte la documentación: [Cómo implementar una instancia de servidor BTCPay] (https://github.com/btcpayserver/btcpayserver-doc/#deployment).

## Altcoins soportados

Bitcoin es el único foco del proyecto y sus desarrolladores centrales. Sin embargo, las integraciones de opt están presentes para varios altcoins:

* Bitcore (BTX)
* Dash (DASH)
* Dogecoin (DOGE)
* Feathercoin (FTC)
* Groestlcoin (GRS)
* Litecoin (LTC)
* Monacoin (MONA)
* Polis (POLIS)
* Viacoin (VIA)
* BGold (BTG) (también conocido como Bitcoin Gold)
* BPlus (XBC) (también conocido como Bitcoin Plus)

Los altcoins son mantenidos por sus respectivas comunidades.
