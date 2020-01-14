# C#

Este proyecto contiene una configuración básica de C# con [NUnit](https://nunit.org/) como framework de testing.

## Preparación del Entorno:

Para trabajar con C# y usar el framework NUnit se necesitará tener instalado: .Net Core o .Net Framework. Para ello, podéis acceder a [esta](https://www.microsoft.com/net/download) web para descargar todo lo necesario.


Para la estructura y para los pasos que se describen a continuación se ha usado [Visual Studio Code](https://code.visualstudio.com/download) v1.28.2. Información Sobre NUnit: https://nunit.org/

## Extensiones Usadas de VSCode:

- `ms-vscode.csharp`
- `jorgeserrano.vscode-csharp-snippets`

## Pasos necesarios para ejecutar los tests de esta solución:

 1. Abrir el proyecto en Visual Studio Code
 2. Moverse a la carpeta BusinessLogic.Tests
 3. Ejecutar el comando `dotnet test`

## Comandos Consola `dotnet`:

- `dotnet build`: compila solución.
- `dotnet run`: ejecuta proyecto contenga el método main.
- `dotnet test`: ejecuta las pruebas, lanzar desde la carpeta de los tests.
