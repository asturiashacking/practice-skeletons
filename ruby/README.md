# Ruby

Este es un punto de partida para proyectos de Ruby testeados con
[RSpec](http://rspec.info/).

## Instalación

Para poder empezar a trabajar con este proyecto necesitarás una [instalación de
Ruby](https://www.ruby-lang.org/es/documentation/installation/) para tu SO.

Una vez hayas instalado ruby, deberás instalar [Bundler](https://bundler.io/),
es muy sencillo, simplemente:

```sh
gem install bundler
```

(Si usas linux es posible que tengas que usar `sudo`, depende del método de
instalación que hayas utilizado).

Ahora desde la raíz del proyecto puedes instalar el resto de dependencias
con

```sh
bundle
```

## Ejecutar tests

Muy sencillo, desde la raíz del proyecto:

```sh
bundle exec rspec
```

## Otros

El proyecto incluye [Rubocop](https://github.com/rubocop-hq/rubocop) para
identificar violaciones de las guía de estilo de Ruby y algunos _code smells_,
puedes obtener un análisis con

```sh
bundle exec rubocop
```

