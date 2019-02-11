# JavaScript

Este proyecto contiene una configuración básica de JavaScript a través de [Node.js](https://nodejs.org/en/) con [Jest](https://jestjs.io/) como framework de testing. Como herramientas de apoyo, también está instalado [ESLint](https://eslint.org/) y un conjunto de paquetes que notificarán sobre posibles [_code smells_](https://en.wikipedia.org/wiki/Code_smell). Para ayudar con el formateo de código y errores estilísticos, se recomienda utilizar [Prettier](https://prettier.io/) (cuya configuración ya está incluida en el repositorio) con soporte para numerosos editores de texto como VS Code, Atom, etc.

## ¿Cómo...?

### Instalar dependencias

Utiliza `npm` para instalar las dependencias de este proyecto desde su propia raíz a través de una interfaz de línea de comandos:

```sh
npm i
```

### Ejecutar la suite de tests

Hay una serie de scripts de `npm` preparados para ejecutar la suite de pruebas:

```sh
npm run test        # ejecuta la suite completa
npm run test:watch  # ejecución continua de los tests con cambios relacionados
```

### Analizar el código

A través de `npm run lint` podrás obtener un informe del conjunto de _code smells_ identificados por ESLint.
