# Elixir

Este proyecto contiene una configuración básica de [Elixir](https://elixir-lang.org/) con [ExUnit](https://hexdocs.pm/ex_unit/1.9.4/ExUnit.html) como framework de testing. Como herramienta de apoyo, también está instalado [credo](https://github.com/rrrene/credo) para el análisis sintántico del código.

## ¿Cómo...?

### Instalar entorno

Para ejecutar el proyecto tienes que instalar `erlang` y `elixir`. Te recomiendo utilizar un gestor de paquetes como [asdf](https://github.com/asdf-vm/asdf).

Una vez instalado, tienes que instalar las siguientes versiones de `erlang` y `elixir`:

```sh
asdf plugin-add erlang
asdf plugin-add elixir
asdf install erlang 22.2.1
asdf install elixir 1.9.4
```

### Instalar paquetes

Utiliza `mix` para instalar las dependencias de este proyecto desde su propia raíz a través de una interfaz de línea de comandos:

```sh
mix deps.get
```

### Ejecutar la suite de tests

Para ejecutar la suite de test, ejecuta desde la raíz del proyecto:

```sh
mix test
```

### Analizar el código

El proyecto incluye [credo](https://github.com/rrrene/credo) para identificar violaciones de las guía de estilo de Elixir y algunos _code smells_.

```sh
mix credo
```
