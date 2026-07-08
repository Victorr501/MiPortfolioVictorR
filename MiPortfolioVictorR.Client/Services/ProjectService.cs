using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class ProjectService
    {
        public List<Project> GetProjects() => [
            new Project{
                Id = 19,
                Title = "Trabajo 2: Python Programación Orientada a Objetos",
                TitleEn = "Assignment 2: Object-Oriented Programming with Python",
                Description = "Desarrollar un sistema básico de inventario con POO en Python para gestionar productos y realizar operaciones de inventario.",
                DescriptionEn = "Development of a basic inventory system in Python using OOP to manage products and perform inventory operations.",
                GitHubUrl = "https://github.com/Victorr501/Trabajo-2-Python-Programaci-n-Orientada-a-Objetos",
                Tags = ["Python"],
                IsFeatured = false,
                Category = "Desarrollo Multiplataforma y Web"
            },
            new Project{
                Id = 18,
                Title = "Trabajo-1-Sintaxis-Python",
                TitleEn = "Assignment 1: Python Syntax",
                Description = "Desarrollo de una calculadora de promedios escolares en Python utilizando variables, operadores, estructuras de control y funciones básicas.",
                DescriptionEn = "Development of a school grade average calculator in Python using variables, operators, control structures, and basic functions.",
                GitHubUrl = "https://github.com/Victorr501/Trabajo-1-Sintaxis-Python",
                Tags = ["Python"],
                IsFeatured = false,
                Category = "Desarrollo Multiplataforma y Web"
            },
            new Project{
                Id = 17,
                Title = "Calculadora de Matrices",
                TitleEn = "Matrix Calculator",
                Description = "Calculadora de matrices desarrollada con JavaScript y react.js. Permite realizar operaciones como suma, resta, multiplicación y determinante de matrices.",
                DescriptionEn = "Matrix calculator developed with JavaScript and react.js. Allows performing operations such as addition, subtraction, multiplication and determinant of matrices.",
                GitHubUrl = "https://github.com/Victorr501/CaluladoraMatrices",
                Tags = ["JavaScript", "React.js"],
                IsFeatured = true,
                Category = "Desarrollo Multiplataforma y Web",
            },
            new Project{
                Id = 15,
                Title = "Aplicacion Daltonicos",
                TitleEn = "Color Blindness App",
                Description = "AppColoresDaltonicos es una aplicacion movil cliente-servidor para accesibilidad visual. El frontend esta desarrollado en .NET MAUI (C#, XAML) bajo el patron MVVM y AppShell. El backend es una API REST en ASP.NET Core con arquitectura multicapa y patron repositorio generico, utilizando Entity Framework Core (Code-First) sobre SQL Server. El sistema integra inyeccion de dependencias, AutoMapper para DTOs, autenticacion con JWT y encriptacion de contrasenas con BCrypt.",
                DescriptionEn = "AppColoresDaltonicos is a client-server mobile app for visual accessibility. The frontend is built with .NET MAUI (C#, XAML) using the MVVM pattern and AppShell. The backend is a REST API in ASP.NET Core with a multi-layer architecture and generic repository pattern, using Entity Framework Core (Code-First) on SQL Server. The system integrates dependency injection, AutoMapper for DTOs, JWT authentication and BCrypt password encryption.",
                GitHubUrl = "https://github.com/Victorr501/AppColoresDaltonicos",
                Tags = [".NET", "C#", "ASP.NET", ".NET MAUI", "Andorid/IOS"],
                IsFeatured = true,
                Category = "Desarrollo Multiplataforma y Web"
            },
            new Project
            {
                Id = 2,
                Title = "AgenteIA_OrdenarTarea",
                TitleEn = "AgenteIA_OrdenarTarea",
                Description = "App de terminal en Python con modelo de Machine Learning entrenable para predecir la prioridad de tareas (alta, media, baja) según ejemplos reales. Aprende a construir una IA práctica: datos, entrenamiento, guardado del modelo y predicción desde consola.",
                DescriptionEn = "Python terminal app with a trainable ML model to predict task priority (high, medium, low) based on real examples. Learn to build a practical AI: data collection, training, model saving and prediction from the console.",
                GitHubUrl = "https://github.com/Victorr501/AgenteIA_OrdenarTarea",
                Tags = ["Python", "Machine Learning"],
                IsFeatured = true,
                Category = "Herramientas y Utilidades"
            },
            new Project
            {
                Id = 3,
                Title = "Aplicacion_Uso_Movil",
                TitleEn = "Aplicacion_Uso_Movil",
                Description = "App Python que detecta con la cámara cuando se usa el móvil y reproduce automáticamente música y fotos en el PC.",
                DescriptionEn = "Python app that detects phone usage via camera and automatically plays music and photos on the PC.",
                GitHubUrl = "https://github.com/Victorr501/Aplicacion_Uso_Movil",
                YouTubeUrl = "https://www.youtube.com/watch?v=2xj4kbRDh-0",
                Tags = ["Python", "Computer Vision"],
                IsFeatured = false,
                Category = "Herramientas y Utilidades"
            },
            new Project
            {
                Id = 16,
                Title = "Mi Portfolio",
                TitleEn = "My Portfolio",
                Description = "Portfolio personal desarrollado con Blazor WebAssembly y .NET 8, desplegado en Azure App Service. Incluye secciones de experiencia, proyectos, Trackify PFC, tecnologías y estudios.",
                DescriptionEn = "Personal portfolio built with Blazor WebAssembly and .NET 8, deployed on Azure App Service. Includes sections for experience, projects, Trackify PFC, technologies and education.",
                GitHubUrl = "https://github.com/Victorr501/MiPortfolioVictorR",
                LiveUrl = "https://victorrubin-deejedgugtfge3fg.spaincentral-01.azurewebsites.net",
                Tags = ["Blazor WASM", ".NET 8", "Azure", "C#"],
                IsFeatured = false,
                Category = "Desarrollo Multiplataforma y Web"
            },
            new Project
            {
                Id = 1,
                Title = "Gestor",
                TitleEn = "Finance Manager",
                Description = "App móvil financiera completa. Backend con Python, FastAPI y PostgreSQL usando NumPy y Pandas para cálculos financieros. Frontend con React Native y Expo. Infraestructura con Docker. Integra Firebase y Google Calendar API.",
                DescriptionEn = "Full-featured financial mobile app. Backend with Python, FastAPI and PostgreSQL using NumPy and Pandas for financial calculations. Frontend with React Native and Expo. Docker infrastructure. Integrates Firebase and Google Calendar API.",
                GitHubUrl = "https://github.com/Victorr501/GestorFrontEnd",
                GitHubUrlBackend = "https://github.com/Victorr501/GestorBackEnd",
                Tags = ["Python", "FastAPI", "PostgreSQL", "React Native", "Docker", "Firebase"],
                IsFeatured = false,
                Category = "Desarrollo Multiplataforma y Web"
            },
            new Project
            {
                Id = 4,
                Title = "ProyectoFX",
                TitleEn = "ProyectoFX",
                Description = "App cliente-servidor para gestionar proyectos personales desarrollada con Spring Boot, JavaFX e Hibernate. Permite organizar tareas, establecer prioridades y hacer seguimiento del progreso.",
                DescriptionEn = "Client-server app for managing personal projects built with Spring Boot, JavaFX and Hibernate. Allows organizing tasks, setting priorities and tracking progress.",
                GitHubUrl = "https://github.com/Victorr501/proyectoFX-FrontEnd",
                GitHubUrlBackend = "https://github.com/Victorr501/proyectoFX-BackEnd",
                Tags = ["Java", "Spring Boot", "JavaFX", "Hibernate", "PostgreSQL"],
                IsFeatured = false,
                Category = "Desarrollo Multiplataforma y Web"
            },
            new Project
            {
                Id = 5,
                Title = "agents-templates",
                TitleEn = "agents-templates",
                Description = "Plantillas agents.md para los principales lenguajes de programación. Facilita el copiado y pegado en nuevos proyectos, se pueden modificar según las necesidades de cada uno y usar como referencia para agentes de IA.",
                DescriptionEn = "agents.md templates for the main programming languages. Easy to copy and paste into new projects, customizable to your needs and usable as reference for AI agents.",
                GitHubUrl = "https://github.com/Victorr501/agents-templates",
                Tags = ["IA", "Productividad"],
                IsFeatured = false,
                Category = "Herramientas y Utilidades"
            },
            new Project
            {
                Id = 6,
                Title = "Contoso Pets",
                TitleEn = "Contoso Pets",
                Description = "Práctica de la ruta de aprendizaje de Microsoft Learn (Adición de lógica a aplicaciones de consola de C#). App para buscar hogar a mascotas.",
                DescriptionEn = "Practice project from the Microsoft Learn learning path (Adding Logic to C# Console Applications). App for finding homes for pets.",
                GitHubUrl = "https://github.com/Victorr501/ContosoPets",
                Tags = ["C#", ".NET", "Microsoft Learn"],
                IsFeatured = false,
                Category = "Herramientas y Utilidades"
            },
            new Project
            {
                Id = 7,
                Title = "Gestor — Página web",
                TitleEn = "Finance Manager — Web page",
                Description = "Página web sencilla para recuperación de contraseña del proyecto Gestor.",
                DescriptionEn = "Simple web page for password recovery for the Finance Manager project.",
                GitHubUrl = "https://github.com/Victorr501/GestorPaginaWeb",
                Tags = ["HTML", "CSS", "JavaScript"],
                IsFeatured = false,
                Category = "Desarrollo Multiplataforma y Web"
            },
            new Project
            {
                Id = 8,
                Title = "AplicacionFX",
                TitleEn = "AplicacionFX",
                Description = "Campo de aprendizaje de JavaFX, FXML y CSS para interfaces de escritorio. Cada línea de código es una oportunidad para dominar el montaje de interfaces modernas.",
                DescriptionEn = "Learning playground for JavaFX, FXML and CSS for desktop interfaces. Every line of code is an opportunity to master modern interface design.",
                GitHubUrl = "https://github.com/Victorr501/AplicacionFX",
                GitHubUrlBackend = "https://github.com/Victorr501/AplicacionFX-Backend",
                Tags = ["Java", "JavaFX", "Spring Boot", "PostgreSQL"],
                IsFeatured = false,
                Category = "Desarrollo Multiplataforma y Web"
            },
            new Project
            {
                Id = 9,
                Title = "InterfacesProyecto",
                TitleEn = "InterfacesProyecto",
                Description = "Gestor de datos para pedidos desarrollado con Java y su sistema de eventos. Proyecto académico completamente funcional.",
                DescriptionEn = "Order data manager developed with Java and its event system. Fully functional academic project.",
                GitHubUrl = "https://github.com/Victorr501/interfacesProyecto",
                Tags = ["Java"],
                IsFeatured = false,
                Category = "Desarrollo Multiplataforma y Web"
            },
            new Project
            {
                Id = 10,
                Title = "Aprender Python Ejercicios",
                TitleEn = "Learning Python: Exercises",
                Description = "Ejercicios, ejemplos y apuntes para aprender Python desde cero: variables, tipos de datos, estructuras, funciones y POO.",
                DescriptionEn = "Exercises, examples and notes to learn Python from scratch: variables, data types, structures, functions and OOP.",
                GitHubUrl = "https://github.com/Victorr501/PracticaPythonEjercicios",
                Tags = ["Python"],
                IsFeatured = false,
                Category = "Herramientas y Utilidades"
            },
            new Project
            {
                Id = 11,
                Title = "Aprender FastAPI",
                TitleEn = "Learning FastAPI",
                Description = "Código de aprendizaje de backend con FastAPI. Base para implementar todo lo aprendido en un proyecto real.",
                DescriptionEn = "FastAPI backend learning code. Foundation for applying everything learned in a real project.",
                GitHubUrl = "https://github.com/Victorr501/PracicasPython",
                Tags = ["Python", "FastAPI"],
                IsFeatured = false,
                Category = "Herramientas y Utilidades"
            },
            new Project
            {
                Id = 12,
                Title = "Proyectos para aprender C#",
                TitleEn = "C# Learning Projects",
                Description = "Ejercicios prácticos de pequeña escala para familiarizarse con la sintaxis y las bases de C#.",
                DescriptionEn = "Small-scale practical exercises to get familiar with C# syntax and fundamentals.",
                GitHubUrl = "https://github.com/Victorr501/Ejercicio1",
                Tags = ["C#", ".NET"],
                IsFeatured = false,
                Category = "Herramientas y Utilidades"
            },
            new Project
            {
                Id = 13,
                Title = "PaginaWeb",
                TitleEn = "Personal Website",
                Description = "Primera página web personal para practicar tras finalizar el grado superior.",
                DescriptionEn = "First personal website built to practice after completing the higher degree.",
                GitHubUrl = "https://github.com/Victorr501/PaginaWeb",
                Tags = ["HTML", "CSS", "JavaScript"],
                IsFeatured = false,
                Category = "Desarrollo Multiplataforma y Web"
            },
            new Project
            {
                Id = 14,
                Title = "AprenderPython",
                TitleEn = "Learning Python",
                Description = "Proyecto de práctica para aprender y afianzar conocimientos en Python.",
                DescriptionEn = "Practice project to learn and consolidate Python knowledge.",
                GitHubUrl = "https://github.com/Victorr501/AprenderPyhton",
                Tags = ["Python"],
                IsFeatured = false,
                Category = "Herramientas y Utilidades"
            }
        ];

        public List<Project> GetFeatured() =>
            GetProjects().Where(p => p.IsFeatured).ToList();

        public Project? GetById(int id) =>
            GetProjects().FirstOrDefault(p => p.Id == id);

        public List<Project> GetByCategory(string category) =>
            GetProjects().Where(p => p.Category == category).ToList();

        public List<string> GetDistinctCategories() =>
            GetProjects()
                .Where(p => !string.IsNullOrEmpty(p.Category))
                .Select(p => p.Category)
                .Distinct()
                .ToList();
    }
}