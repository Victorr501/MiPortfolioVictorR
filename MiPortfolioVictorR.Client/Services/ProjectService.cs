using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class ProjectService
    {

        public List<Project> GetProjects() =>[
            new Project{
                Id = 15,
                Title = "Aplicacion Daltonicos",
                Description = "AppColoresDaltonicos es una aplicacion movil cliente-servidor para accesibilidad visual. El frontend esta desarrollado en .NET MAUI (C#, XAML) bajo el patron MVVM y AppShell. El backend es una API REST en ASP.NET Core con arquitectura multicapa y patron repositorio generico, utilizando Entity Framework Core (Code-First) sobre SQL Server. El sistema integra inyeccion de dependencias, AutoMapper para DTOs, autenticacion con JWT y encriptacion de contrasenas con BCrypt.",
                GitHubUrl = "https://github.com/Victorr501/AppColoresDaltonicos",
                Tags = [".NET", "C#", "ASP.NET", ".NET MAUI", "Andorid/IOS"],
                IsFeatured = true,
            },
            new Project
            {
                Id          = 2,
                Title       = "AgenteIA_OrdenarTarea",
                Description = "App de terminal en Python con modelo de Machine Learning entrenable para predecir la prioridad de tareas (alta, media, baja) según ejemplos reales. Aprende a construir una IA práctica: datos, entrenamiento, guardado del modelo y predicción desde consola.",
                GitHubUrl   = "https://github.com/Victorr501/AgenteIA_OrdenarTarea",
                Tags        = ["Python", "Machine Learning"],
                IsFeatured  = true
            },
            new Project
            {
                Id          = 3,
                Title       = "Aplicacion_Uso_Movil",
                Description = "App Python que detecta con la cámara cuando se usa el móvil y reproduce automáticamente música y fotos en el PC.",
                GitHubUrl   = "https://github.com/Victorr501/Aplicacion_Uso_Movil",
                YouTubeUrl  = "https://www.youtube.com/watch?v=2xj4kbRDh-0",
                Tags        = ["Python", "Computer Vision"],
                IsFeatured  = true
            },
            new Project
            {
                Id          = 16,
                Title       = "Mi Portfolio",
                Description = "Portfolio personal desarrollado con Blazor WebAssembly y .NET 8, desplegado en Azure App Service. Incluye secciones de experiencia, proyectos, Trackify PFC, tecnologías y estudios.",
                GitHubUrl   = "https://github.com/Victorr501/MiPortfolioVictorR",
                LiveUrl     = "https://victorrubin-deejedgugtfge3fg.spaincentral-01.azurewebsites.net",
                Tags        = ["Blazor WASM", ".NET 8", "Azure", "C#"],
                IsFeatured  = false
            },
            new Project
            {
                Id          = 1,
                Title       = "Gestor",
                Description = "App móvil financiera completa. Backend con Python, FastAPI y PostgreSQL usando NumPy y Pandas para cálculos financieros. Frontend con React Native y Expo. Infraestructura con Docker. Integra Firebase y Google Calendar API.",
                GitHubUrl        = "https://github.com/Victorr501/GestorFrontEnd",
                GitHubUrlBackend = "https://github.com/Victorr501/GestorBackEnd",
                Tags        = ["Python", "FastAPI", "PostgreSQL", "React Native", "Docker", "Firebase"],
                IsFeatured  = false,
            },
            new Project
            {
                Id          = 4,
                Title       = "ProyectoFX",
                Description = "App cliente-servidor para gestionar proyectos personales desarrollada con Spring Boot, JavaFX e Hibernate. Permite organizar tareas, establecer prioridades y hacer seguimiento del progreso.",
                GitHubUrl        = "https://github.com/Victorr501/proyectoFX-FrontEnd",
                GitHubUrlBackend = "https://github.com/Victorr501/proyectoFX-BackEnd",
                Tags        = ["Java", "Spring Boot", "JavaFX", "Hibernate", "PostgreSQL"],
                IsFeatured  = false
            },
            new Project
            {
                Id          = 5,
                Title       = "agents-templates",
                Description = "Plantillas agents.md para los principales lenguajes de programación. Facilita el copiado y pegado en nuevos proyectos, se pueden modificar según las necesidades de cada uno y usar como referencia para agentes de IA.",
                GitHubUrl   = "https://github.com/Victorr501/agents-templates",
                Tags        = ["IA", "Productividad"],
                IsFeatured  = false
            },
            new Project
            {
                Id          = 6,
                Title       = "Contoso Pets",
                Description = "Práctica de la ruta de aprendizaje de Microsoft Learn (Adición de lógica a aplicaciones de consola de C#). App para buscar hogar a mascotas.",
                GitHubUrl   = "https://github.com/Victorr501/ContosoPets",
                Tags        = ["C#", ".NET", "Microsoft Learn"],
                IsFeatured  = false
            },
            new Project
            {
                Id          = 7,
                Title       = "Gestor — Página web",
                Description = "Página web sencilla para recuperación de contraseña del proyecto Gestor.",
                GitHubUrl   = "https://github.com/Victorr501/GestorPaginaWeb",
                Tags        = ["HTML", "CSS", "JavaScript"],
                IsFeatured  = false
            },
            new Project
            {
                Id          = 8,
                Title       = "AplicacionFX",
                Description = "Campo de aprendizaje de JavaFX, FXML y CSS para interfaces de escritorio. Cada línea de código es una oportunidad para dominar el montaje de interfaces modernas.",
                GitHubUrl        = "https://github.com/Victorr501/AplicacionFX",
                GitHubUrlBackend = "https://github.com/Victorr501/AplicacionFX-Backend",
                Tags        = ["Java", "JavaFX", "Spring Boot", "PostgreSQL"],
                IsFeatured  = false
            },
            new Project
            {
                Id          = 9,
                Title       = "InterfacesProyecto",
                Description = "Gestor de datos para pedidos desarrollado con Java y su sistema de eventos. Proyecto académico completamente funcional.",
                GitHubUrl   = "https://github.com/Victorr501/interfacesProyecto",
                Tags        = ["Java"],
                IsFeatured  = false
            },
            new Project
            {
                Id          = 10,
                Title       = "Aprender Python Ejercicios",
                Description = "Ejercicios, ejemplos y apuntes para aprender Python desde cero: variables, tipos de datos, estructuras, funciones y POO.",
                GitHubUrl   = "https://github.com/Victorr501/PracticaPythonEjercicios",
                Tags        = ["Python"],
                IsFeatured  = false
            },
            new Project
            {
                Id          = 11,
                Title       = "Aprender FastAPI",
                Description = "Código de aprendizaje de backend con FastAPI. Base para implementar todo lo aprendido en un proyecto real.",
                GitHubUrl   = "https://github.com/Victorr501/PracicasPython",
                Tags        = ["Python", "FastAPI"],
                IsFeatured  = false
            },
            new Project
            {
                Id          = 12,
                Title       = "Proyectos para aprender C#",
                Description = "Ejercicios prácticos de pequeña escala para familiarizarse con la sintaxis y las bases de C#.",
                GitHubUrl   = "https://github.com/Victorr501/Ejercicio1",
                Tags        = ["C#", ".NET"],
                IsFeatured  = false
            },
            new Project
            {
                Id          = 13,
                Title       = "PaginaWeb",
                Description = "Primera página web personal para practicar tras finalizar el grado superior.",
                GitHubUrl   = "https://github.com/Victorr501/PaginaWeb",
                Tags        = ["HTML", "CSS", "JavaScript"],
                IsFeatured  = false
            },
            new Project
            {
                Id          = 14,
                Title       = "AprenderPython",
                Description = "Proyecto de práctica para aprender y afianzar conocimientos en Python.",
                GitHubUrl   = "https://github.com/Victorr501/AprenderPyhton",
                Tags        = ["Python"],
                IsFeatured  = false
            }
        ];

        public List<Project> GetFeatured() => 
            GetProjects().Where(p => p.IsFeatured).ToList();

        public Project? GetById(int id) => 
            GetProjects().FirstOrDefault(p => p.Id == id);
    }

}
