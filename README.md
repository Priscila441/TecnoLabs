markdown
Copiar código
# 📚 Trabajo Práctico: Aplicación CRUD para Gestión de Libros

Este proyecto forma parte de un trabajo práctico realizado por estudiantes de la facultad, bajo la metodología Scrum. Consiste en el desarrollo de una aplicación CRUD para la gestión de libros, donde los usuarios pueden agregar, visualizar, editar y eliminar registros. La aplicación está desarrollada en C# con una interfaz gráfica en Windows Forms y conectada a una base de datos SQL.

---

## 🌟 Objetivos del Proyecto

1. Implementar una aplicación CRUD que permita gestionar libros.
2. Aplicar conocimientos de **C#**, **SQL** y **Windows Forms**.
3. Utilizar la metodología **Scrum** para organizar el trabajo en equipo.
4. Desarrollar pruebas unitarias y validar la integridad de los datos.

---

## 📝 Fases del Proyecto

### 1. Conformación del Equipo
- Definición de roles y responsabilidades.
- Creación del tablero en Jira para la gestión ágil del proyecto.

### 2. Investigación y Diseño
- Relevamiento de datos de una empresa real o ficticia.
- Diseño del **Diagrama de Clases** para estructurar la base de datos.

### 3. Desarrollo de la Base de Datos
- Creación de la base de datos en **SQL**.
- Inserción de datos de prueba.
- Implementación de **procedimientos almacenados**.

### 4. Programación de la Aplicación
- **Frontend**: Desarrollo de la interfaz de usuario con **Windows Forms**.
- **Backend**: Implementación de las funcionalidades en **C#** (CRUD).
- Conexión con la base de datos y uso de procedimientos almacenados.

### 5. Implementación de Funcionalidades CRUD
- **Crear**: Formulario para añadir nuevos libros.
- **Leer**: Visualización de libros en una tabla.
- **Actualizar**: Edición de los registros seleccionados.
- **Eliminar**: Eliminación de libros desde la interfaz.

### 6. Pruebas y Validación
- Pruebas unitarias para cada una de las operaciones CRUD.
- Validación de datos para evitar inconsistencias.

---

## 🛠️ Tecnologías Utilizadas

- **Lenguaje**: C#
- **Framework**: .NET Framework
- **Base de Datos**: SQL Server
- **Frontend**: Windows Forms
- **Control de Versiones**: Git/GitHub
- **Gestión de Proyecto**: Jira

---

## 🚀 Instrucciones de Instalación

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/usuario/proyecto-crud-libros.git
Abrir el proyecto en Visual Studio.

Crear la base de datos:

Ejecutar el script SQL en el directorio /Database para crear las tablas y los procedimientos almacenados.
Configurar la cadena de conexión en app.config.

Ejecutar la aplicación desde Visual Studio.

📂 Estructura del Proyecto
plaintext
Copiar código
/ProyectoCRUDLibros
│
├── /App
│   ├── Form1.cs           # Interfaz gráfica de usuario
│   ├── Program.cs         # Punto de entrada de la aplicación
│   ├── /Models            # Clases del modelo (diagramas de clases)
│   ├── /Services          # Servicios de conexión con la base de datos
│
├── /Database
│   ├── database.sql       # Script SQL para crear tablas y procedimientos
│
└── README.md              # Archivo de documentación

🧑‍💻 Equipo de Trabajo
    Scrum Master: Cordoba Priscila (https://github.com/priscila441)
    Desarrollador Frontend: Nieto Ayelén (https://github.com/Nietoaye)
    Desarrollador Backend: Coórdoba Gabriel (https://github.com/Gabicba)
    Diseñador de Base de Datos: Medrán Rocío (https://github.com/usuario3)
    
📜 Licencia
Este proyecto se encuentra bajo la licencia MIT. Para más detalles, revisa el archivo LICENSE.

📄 Documentación Adicional
Diagrama de Clases: Consultar el archivo /Diagrams/diagrama_clases.pdf para visualizar el diseño de la base de datos y las clases implementadas.
🤝 Contribuciones
Este proyecto es el resultado de un trabajo académico y está abierto a colaboraciones dentro del equipo. Si tienes alguna sugerencia o encuentras un error, por favor abre un issue o envía un pull request.

### Puntos destacados:
- **Diseño limpio y estructurado** para que sea fácil de leer.
- **Secciones claras** con títulos destacados, lo que facilita la navegación.
- **Detalles técnicos y del equipo** para resaltar el trabajo en equipo y las tecnologías utilizadas.
- **Instrucciones de instalación** sencillas para facilitar la configuración del proyecto.
