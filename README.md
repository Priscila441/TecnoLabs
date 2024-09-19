# 🛍️ TecnoLabsSA: Sistema de Gestión de Productos

Este proyecto es un **Trabajo Integrador** para la materia **Programación 2**. El sistema TecnoLabsSA permite a los usuarios visualizar productos desde una base de datos y ofrece funcionalidades avanzadas para administradores, como la creación, edición y eliminación de productos. La aplicación integra frontend y backend en C# utilizando Windows Forms, y se conecta a una base de datos en **SQL Server**.

---

## 🌟 Objetivos del Proyecto

1. **Visualización de productos**: Los clientes pueden consultar el catálogo de productos.
2. **Gestión administrativa**: Los administradores pueden agregar, modificar o eliminar productos después de autenticarse.
3. Aplicar conceptos de **frontend**, **backend** y **bases de datos** en una aplicación integrada.
4. **Metodología Scrum**: Gestión de trabajo en equipo utilizando **Jira** para una entrega ágil.

---

## 🛠️ Tecnologías Utilizadas

- **Lenguaje**: C#
- **Framework**: .NET Framework
- **Frontend**: Windows Forms
- **Backend**: C# .NET
- **Base de Datos**: SQL Server
- **Diagramas de Clases**: Lucidchart
- **Control de Versiones**: Git/GitHub
- **Herramientas de Diseño**: Figma
- **Gestión de Proyecto**: Jira, Confluence

---

## 🚀 Instrucciones de Instalación

1. **Clonar el repositorio**:
   ```bash
   git clone https://github.com/usuario/proyecto-tecnolabsSA.git
Abrir el proyecto:

Abre Visual Studio y selecciona el archivo de solución (.sln) para cargar el proyecto.
Configurar la base de datos:

Asegúrate de tener SQL Server instalado.
En el directorio /Database, encontrarás un archivo database.sql que contiene el script necesario para crear las tablas y la estructura de la base de datos. Ejecuta este script en SQL Server.
Inserta algunos datos de prueba si es necesario o sigue las instrucciones proporcionadas en el script.
Configurar la cadena de conexión:

Ve al archivo app.config y actualiza la cadena de conexión a tu instancia local de SQL Server.
Asegúrate de que el nombre de la base de datos y las credenciales sean correctas.
Ejecutar la aplicación:

En Visual Studio, selecciona el proyecto principal y ejecuta la aplicación (Ctrl + F5).
El sistema te permitirá ingresar con un usuario administrador para acceder a las funcionalidades de gestión de productos.
📂 Estructura del Proyecto
plaintext
Copiar código
/TecnoLabsSA
│
├── /App
│   ├── Form1.cs           # Interfaz gráfica para clientes y administradores
│   ├── LoginForm.cs       # Formulario de inicio de sesión
│   ├── AdminForm.cs       # Panel de administración
│   ├── Program.cs         # Punto de entrada de la aplicación
│   ├── /Models            # Clases del modelo (diagramas de clases)
│   ├── /Services          # Servicios de conexión a la base de datos
│
├── /Database
│   ├── database.sql       # Script SQL para crear tablas y procedimientos
│
└── README.md              # Archivo de documentación
👥 Equipo de Trabajo
Scrum Master: Cordoba Priscila (https://github.com/priscila441)
Desarrollador Frontend: Nieto Ayelén (https://github.com/Nietoaye)
Desarrollador Backend: Coórdoba Gabriel (https://github.com/Gabicba)
Diseñador de Base de Datos: Medrán Rocío (https://github.com/usuario3)
🤝 Contribuciones
Las contribuciones se manejan entre los miembros del equipo a través de pull requests y discusiones en el tablero de Jira.

🧪 Pruebas y Validación
El sistema de validación y pruebas es manual. Se realizan pruebas para asegurar que cada funcionalidad CRUD (Crear, Leer, Actualizar, Eliminar) funcione correctamente y que los datos ingresados sean válidos.

📄 Documentación Adicional
Diagrama de Clases: Disponible en el archivo /Diagrams/diagrama_clases.pdf y diseñado en Lucidchart.
Tablero Scrum: Gestionado en Jira para el seguimiento de las tareas y el progreso del proyecto.
markdown
Copiar código

### Instrucciones de Instalación Explicadas:
- **Clonar el repositorio**: Este paso permite a los desarrolladores descargar el código fuente del proyecto.
- **Abrir el proyecto en Visual Studio**: Aquí, se debe abrir el archivo de solución (`.sln`), lo cual carga la estructura del proyecto en el entorno de desarrollo.
- **Configurar la base de datos**: Ejecutar el archivo `database.sql` en SQL Server para crear las tablas y la estructura de datos. Es importante asegurarse de que la conexión con la base de datos esté bien configurada.
- **Configurar la cadena de conexión**: Este paso adapta la conexión entre la aplicación y SQL Server, con ajustes que dependen de cada entorno.
- **Ejecutar la aplicación**: Finalmente, se corre el proyecto para probar las funcionalidades.
