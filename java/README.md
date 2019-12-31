# Java

Este proyecto contiene una configuración básica de [Java](https://www.java.com) con [Gradle](https://gradle.org) para la gestión de dependencias y [JUnit](https://junit.org/junit5/) como framework de testing.

## ¿Cómo...?

### Instalar un JDK

Para trabajar con Java necesitamos un [JDK](https://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html)

### Instalar gradle

Lo más cómodo:

```sh
brew install gradle     # OS X
choco install gradle    # Chocolatery @ Windows
```

https://gradle.org/install/#manually Para el resto de opciones.


### Ejecutar la suite de tests

Hay una serie de scripts de `gradle` preparados para ejecutar la aplicación y la suite de tests:

```sh
gradle run         # ejecuta la aplicación
gradle test        # ejecuta la suite completa
```


### IDEs recomendados

Utilizar el editor de texto que más os guste pues para la compilación, ejecución y ejercicio de tests se puede utilizar desde la consola. Algunos recomendados pueden ser Eclipse, STS, Netbeans... cualquiera funcionará bien, incluso Visual Studio Code.