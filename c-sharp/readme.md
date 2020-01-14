# C Sharp 'c#'
Este proyecto contiene una configuración básica de C Sharp con NUnit como framework de testing.

* Preparación del Entorno:
Para trabajar con c# y usar el framework NUnit se necesitará tener instalado:

.Net Core o .Net Framework

Para ello podéis acceder a la siguiente web para descargar todo lo necesario:

https://www.microsoft.com/net/download

Además de esto necesitaréis un editor de texto.

Para la estructura y para los pasos que se describen a continuación se ha usado el Visual Studio Code v1.28.2

https://code.visualstudio.com/download

Información Sobre NUnit:
https://nunit.org/

* Extensiones Usadas de VSCode:

> ms-vscode.csharp 
> jorgeserrano.vscode-csharp-snippets

*Pasos necesarios para ejecutar los tests de esta solución:

 1. Abrir el proyecto en Visual Studio Code
 2. Posicionarse en la carpeta BusinessLogic.Tests
 3. Ejecutar el comando dotnet test

* Pasos realizados para crear la solución:

> a. Hemos creado la carpeta llamada 'C-SHARP'.

> b. Abrimos la carpeta con el VSCode.

> c. Ejecutamos el comando 'dotnet new sln' nos crea el archivo de configuración de la solución C-SHARP.sln.

> d. Creamos la carpeta AppConsole dentro de la carpeta C-SHARP.

> e. Accedemos a la carpeta AppConsole y creamos un proyecto de consola con el comando 'dotnet new console'.

> f. Este proyecto sería usado para acceder a la funcionalidad creada y verla por consola. De momento y por defecto crea la clase Program.cs que imprimirá por pantalla un "Hello World!".

> g. Añadimos el proyecto a la solución con el comando 'dotnet sln add AppConsole/AppConsole.csproj' desde la carpeta raíz

> g. Creamos la carpeta BusinessLogic dentro de la carpeta C-SHARP, esta carpeta tendrá las clases con la lógica de negocio.

> h. Accedemos a la carpeta BusinessLogic dentro de la carpeta C-SHARP con el comando 'dotnet new classlib'.

> i. Renombramos la clase Class1.cs a Sum.cs (tanto el fichero como dentro de él).

> j. Añadimos la librería a la solución con el comando 'dotnet sln add BusinessLogic/BusinessLogic.csproj' desde la carpeta raíz.

> k. Añadimos la referencia de la librería BusinessLogic al proyecto AppConsole usando el comando: 'dotnet add reference ../BusinessLogic/BusinessLogic.csproj' desde la carpeta AppConsole.

> l. Creamos carpeta BusinessLogic.Tests.

> m. Creamos proyecto en la carpeta BusinessLogic.Tests para los tests con el comando 'dotnet new nunit'.

> n. Agregamos la librería BusinessLogic al proyecto de tests con el comando 'dotnet add reference ../BusinessLogic/BusinessLogic.csproj'.

> o. Agregamos el proyecto BusinessLogic.Tests a la solución con el comando 'dotnet sln add BusinessLogic.Tests/BusinessLogic.Tests.csproj' desde la carpeta raíz.

> p. Renombramos el fichero UnitTes1.cs a SumTest.cs.

> q. Renombramos la clase Tests a SumTest dentro del fichero SumTest.cs.

> r. Renombramos el namespace de Tests a BusinessLogic.Tests dentro del fichero SumTest.cs.

> s. Añadimos en la clase SumTest.cs el 'using BusinessLogic'.

> t. Completamos la clase SumTest.cs con la Anotación '[TestFixture]' y completamos la clase con una instancia a la clase Sum.cs.


* Comandos Consola dotnet:

>  1. dotnet new sln --> crear solución.

>  2. dotnet new console --> crear proyecto consola.

>  2. b. dotnet new console -o MyApp --> crear proyecto consola creando el directorio MyApp.

>  3. dotnet new classlib --> crear librería.

>  4. dotnet build --> compilar solución.

>  5. dotnet run --> ejecutar proyecto contenga el método main.

>  6. dotnet test --> ejecutar las pruebas, lanzar desde la carpeta de los tests.

>  7. dotnet sln add BusinessLogic/BusinessLogic.csproj --> agrega el proyecto librería a la solución.

>  8. dotnet new nunit --> crear proyecto de tests, he instala automáticamente los paquetes:

dotnet add package Microsoft.NET.Test.Sdk
dotnet add package Nunit3TestAdapter
dotnet add package NUnit

>  9. dotnet add reference ../BusinessLogic/BusinessLogic.csproj --> agregar la librería al proyecto donde estemos situados.

>  10. dotnet sln add .\BusinessLogic.Tests\BusinessLogic.Tests.csproj --> agrega proyectos, librerías, etc. al archivo de la solución.

>  11. dotnet add package [nombre del paquete] --> Añade paquetes al proyecto, librería donde nos encontremos trabajando.
