# C-sharp-skeleton-katas :dog:
*  Proyecto de consola en .Net Core para realizar diferentes katas.  

Si descargas el repositorio completo ya es funcional para hacer diferentes Katas, solo tendrás que asegurarte de revisar el apartado de **Pasos Previos**. Si quisieras crear desde cero toda la solución completa puedes seguir todos los pasos del indice (La solución que contiene el repositorio del Github puede diferenciarse del que se genere siguiendo los pasos al contener algunas modificaciones).

<br/>
<br/>


## Indice :green_book:
* **A.** Pasos Previos
* **B.** Creando una aplicación de consola
* **C.** Algunos comandos Input - Ouput de la consola
* **D.** Como compilar
* **E.** Como Depurar
* **F.** Creación proyecto para albergar la logica
* **G.** Pruebas Unitarias

* Al final de cada apartado habra uno con información relacionada con el mismo

<br/>
<br/>


## Pasos previos :computer:

 **1.** Usando VSCode, se recomienda la instalación de la [extensión de C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) -> ms-dotnettools.csharp , (Se puede usar cualquier editor o IDE) (Ver último  apartado con más extensiones recomendables): 

 **2.** Instalación del [SDK de .Net Core](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-3.1.402-windows-x64-installer)

 **3.** Otras Exensiones:
* .NET Install Tool for Extension Authors --> ms-dotnettools.vscode-dotnet-runtime
* C# Extensions --> jchannon.csharpextensions

<br/>
<br/>

## Creando una aplicación de consola :pager:

* **A.** Creamos una carpeta donde albergaremos el proyecto (el nombre de la carpeta sera el usado para el proyecto también)

* **B.** Desde la terminal nos situamos en el raiz de la carpeta y ejecutamos la siguiente orden:

```C#
dotnet new console
```

* Esto creara un proyecto de tipo consola que por defecto tendra la clase **Program.cs** que contiene el método **Main** que de momento solo mostrar un "Hello World!" por la terminal.


* **C.** Crear archivo de solución para el proyecto (necesario más adelante para añadir los proyectos de test).

```C#
dotnet new sln
```

* **D.** Podemos usar la siguiente orden para ejecutar la aplicación de concola:

```C#
dotnet run
```

### Podéis seguir  también la [guia de microsoft](https://docs.microsoft.com/es-es/dotnet/core/tutorials/with-visual-studio-code):

<br/>
<br/>

## Algunos comandos Input :pencil2: - Ouput :abcd: de la consola que se pueden usar para interaccionar mediante la terminal.

* Leer Información desde la terminal
```C#
 Console.ReadLine();
```

* Mostrar Información en la terminal
```C#
 Console.WriteLine("Hello World!");
 Console.Write("Hello World!");
```

* Esperar a cerrar la consola hasta que se inserte un caracter por la terminal
```C#
Console.ReadKey(true);
```
<br/>
<br/>

## Como compilar :hammer:

```C#
dotnet build
```
<br/>
<br/>


## Como Depurar :eyeglasses:

* Revisar que tengamos el archivo "launch.json" en VSCode deberia estar dentro de la carpeta ".vscode" (si NO se tiene y estamos usando VSCode están facil como ejecutar la aplicación en modo depuración pulsando la tecla **F5**):

```C#
// reemplazar:
"console": "internalConsole",
// por:
"console": "integratedTerminal",
// Este cambio es para poder depurar cuando se usa  'Console'
```

* Colocamos un punto de ruptura en la linea que queramos y pulsamos F5 para iniciar la depuración.

<br/>
<br/>

## Creación proyecto para albergar la logica :book:

* En este paso crearemos un proyecto donde podremos tener las diferentes clases que contendran la lógica de las pruebas de la Kata

* **A.** Creamos el proyecto con el siguiente comando desde la terminal:

```C#
// -o atributo para indicar la ubicación de salida
dotnet new classlib -o BaseBusinessLibrary
```

* **B.** Agregamos el anterior proyecto a la solucción con el siguiente comando:

```C#
dotnet sln add BaseBusinessLibrary/BaseBusinessLibrary.csproj
```

<br/>
<br/>

## Pruebas Unitarias :microscope:

### Descripción 
En el código se ha usado **MStest** también se puede usar con **xUnit** y **nUnit**.

* Acceso al repositorio de [MSTest](https://github.com/Microsoft/testfx-docs)

### Pasos

* **A.** Crear proyecto de Test:

```C#
dotnet new mstest -o LibraryTest
```

* Esto nos creara un proyecto que generara una clase por defecto para albergar los test

* **B.** Añadir proyecto a la solución:

```C#
dotnet sln add LibraryTest/LibraryTest.csproj
```

* **C.** Para poder usar los test añadimos una referencia en el proyecto de BaseBusinessLibrary

```C#
dotnet add LibraryTest/LibraryTest.csproj reference BaseBusinessLibrary/BaseBusinessLibrary.csproj
```

* **D.** Para ejecutar las pruebas usamos el siguiente comando

```C#
dotnet test LibraryTest/LibraryTest.csproj

// con fichero log
dotnet test LibraryTest/LibraryTest.csproj -d my.log
```

### Algunos métodos de aserción

```C#
Assert.AreEqual	-> Comprueba que dos valores u objetos son iguales. 
Assert.AreSame -> Comprueba que dos variables de objeto hacen referencia al mismo objeto. 
Assert.IsFalse -> Comprueba si una condición es false. 
Assert.IsNotNull -> Comprueba que un objeto no es null. 
```

<br/>
<br/>

## [Enlace Comandos](https://docs.microsoft.com/es-es/dotnet/core/tools/) cli .Net Core (dotnet)

