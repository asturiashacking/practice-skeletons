# Contribuir en el proyecto

¡Gracias por interesarte en contribuir y ayudarnos con este proyecto! 🤗

Como ves, este repositorio contiene ejemplos de aplicaciones en diferentes lenguajes de programación. Se trata de un esqueleto muy básico que ofrece la configuración suficiente para poder practicar con cada uno de los lenguajes. De manera adicional, se incluyen también configuraciones que permiten practicar técnicas como [TDD][tdd] (a través de la instalación de un _framework_ de pruebas) y alguna de las herramientas disponibles en el lenguaje con las que poder hacer un análisis estático del código y aportar algo de información sobre posibles [_code smells_][code smells] o buenas prácticas.

## Tipos de contribuciones

### Quiero añadir un nuevo lenguaje

¡Perfecto! ¿Qué necesitamos?

- Crea una carpeta en la raíz del repositorio con el nombre del lenguaje
- Incluye un _framework_ de pruebas _popular_ para el lenguaje
- Incluye información detallada, en un fichero `README.md`, sobre cómo instalar las dependencias necesarias y cómo ejecutar la suite de pruebas
- Incluye un prueba unitaria que se pueda ejecutar de manera exitosa (_a.k.a tener un test en verde_)
- Incluye, si es posible, herramientas existentes en el lenguaje para hacer un análisis estático del código (similar a [Rubocop][rubocop] en Ruby, [ESLint][eslint] en JavaScript o [TSLint][tslint] en TypeScript)

### Quiero propone un cambio en alguno de los esqueletos

¡Genial! Haz un _fork_ del proyecto, crea una rama con los cambios que desees proponer y envía una _Pull Request_ mencionando a alguno de los organizadores de AsturiasHacking.

## Código de Conducta

Aprovechamos para recordarte que todo tipo de participación en AsturiasHacking y sus proyectos relacionados, está sujeta a respetar los puntos descritos en nuestro [Código de Conducta][coc].

[coc]: https://github.com/asturiashacking/core/blob/main/coc/CODE_OF_CONDUCT.md
[code smells]: https://en.wikipedia.org/wiki/Code_smell
[eslint]: https://eslint.org/
[rubocop]: https://github.com/rubocop-hq/rubocop
[tdd]: https://en.wikipedia.org/wiki/Test-driven_development
[tslint]: https://palantir.github.io/tslint/
