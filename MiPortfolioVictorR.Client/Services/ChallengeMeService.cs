using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class ChallengeMeService
    {
        public List<PfcUpdate> GetUpdates() =>
        [
            new PfcUpdate
            {
                Date          = new DateOnly(2026, 05, 02),
                Title         = "Documentación completa del proyecto y arquitectura definida",
                TitleEn       = "Complete project documentation and architecture defined",
                Description   = "He completado la documentación técnica de ChallengMe!, definiendo la arquitectura completa por capas para la API, Web (Blazor), iOS (SwiftUI) y Android (Jetpack Compose). También quedan definidos la paleta de color, tipografía, endpoints con sus modelos de request y response, estructura de base de datos SQL y Cosmos DB, plan de tests unitarios e integración, y el roadmap de publicación con sus costes reales. Toda esta base documental es la que permite mantener cuatro plataformas con coherencia siendo un único desarrollador.",
                DescriptionEn = "I have completed the technical documentation for ChallengMe!, defining the full layered architecture for the API, Web (Blazor), iOS (SwiftUI) and Android (Jetpack Compose). Also defined: color palette, typography, endpoints with their request and response models, SQL and Cosmos DB database structure, unit and integration test plan, and the release roadmap with real costs. This documentation base allows maintaining four platforms with consistency as a solo developer."
            },
            new PfcUpdate
            {
                Date          = new DateOnly(2026, 04, 30),
                Title         = "Suite de tests completa para la API — 29/29 en verde",
                TitleEn       = "Complete test suite for the API — 29/29 passing",
                Description   = "Hoy he implementado la suite de tests completa para ChallengMe! API. Tests unitarios de AuthService cubriendo login con email, registro y login con Microsoft usando Moq para aislar dependencias. Tests unitarios de UsuarioRepository con SQLite en memoria para no tocar Azure SQL. Tests unitarios de AzureAdService simulando respuestas HTTP de Microsoft con un FakeHttpMessageHandler. Y tests de integración del AuthController levantando la API completa en memoria con WebApplicationFactory y verificando que el ExceptionMiddleware convierte las excepciones en los códigos HTTP correctos. Stack de testing: xUnit + Moq + FluentAssertions + SQLite in-memory.",
                DescriptionEn = "Today I implemented the complete test suite for ChallengMe! API. Unit tests for AuthService covering email login, registration and Microsoft login using Moq to isolate dependencies. Unit tests for UsuarioRepository with SQLite in-memory to avoid touching Azure SQL. Unit tests for AzureAdService simulating Microsoft HTTP responses with a FakeHttpMessageHandler. And integration tests for the AuthController spinning up the full API in-memory with WebApplicationFactory and verifying the ExceptionMiddleware converts exceptions into the correct HTTP codes. Testing stack: xUnit + Moq + FluentAssertions + SQLite in-memory."
            },
            new PfcUpdate
            {
                Date          = new DateOnly(2026, 04, 24),
                Title         = "Icono diseñado a mano e implementado en web y móvil",
                TitleEn       = "Hand-drawn icon designed and implemented on web and mobile",
                Description   = "He diseñado el icono de ChallengMe! desde cero a mano, digitalizándolo e integrándolo tanto en la aplicación web como en las apps móviles de iOS y Android. Un detalle de identidad visual que le da carácter propio al proyecto más allá del código.",
                DescriptionEn = "I designed the ChallengMe! icon from scratch by hand, digitized it and integrated it into both the web application and the iOS and Android mobile apps. A visual identity detail that gives the project its own character beyond the code."
            },
            new PfcUpdate
            {
                Date          = new DateOnly(2026, 04, 22),
                Title         = "Desarrollo de login en Android, diseño de logo y planificación de escalabilidad",
                TitleEn       = "Android login development, logo design and scalability planning",
                Description   = "Ya he desarrollado el login y registro en ChallengMe para Android usando Kotlin. Además, he terminado de diseñar el logo de la aplicación. Los siguientes pasos serán integrar este logo en las interfaces, investigar el proceso de publicación en la AppStore y PlayStore, y desarrollar los tests de la API, una tarea invisible para el usuario pero fundamental para asegurar la escalabilidad del proyecto.",
                DescriptionEn = "I have developed the login and registration for ChallengMe on Android using Kotlin. I have also finished designing the app logo. Next steps will be to integrate the logo into the interfaces, research the publishing process on the AppStore and PlayStore, and develop API tests — invisible to the user but essential for ensuring project scalability."
            },
            new PfcUpdate
            {
                Date          = new DateOnly(2026, 04, 19),
                Title         = "Desarrollo inicial de iOS completado y planificación para Android",
                TitleEn       = "Initial iOS development completed and Android planning",
                Description   = "Ya he desarrollado el login, registro y la pantalla principal de mi proyecto ChallengMe! en iOS. Está funcionando perfectamente, usando el mismo servidor que la página web. Lo próximo que haré será desarrollar la versión para Android usando Kotlin (manteniendo las mismas funciones), crear el icono de la aplicación y publicar ambas versiones para que las podáis ir descargando y probando.",
                DescriptionEn = "I have developed the login, registration and main screen of my ChallengMe! project on iOS. It is working perfectly, using the same server as the web page. Next I will develop the Android version using Kotlin (keeping the same features), create the app icon and publish both versions for testing."
            },
            new PfcUpdate
            {
                Date          = new DateOnly(2026, 04, 13),
                Title         = "Solucion de la discrepancia del entorno y creacion de la aplicacion para android",
                TitleEn       = "Resolved environment discrepancy and created the Android app",
                Description   = "Ya he terminado de solucionar el problema en la autenticacion, al final lo que he tenido que hacer es usar localstorage en vez de la cookes devido a que una vez arrancada la pestaña yo no podia hacer una peticion al servidor ya que el http estaba desabilitado. A ademas he creado ya el repostirio para la aplicacion en Android usando Kotlin",
                DescriptionEn = "I finished resolving the authentication issue. I had to use localStorage instead of cookies because once the tab was launched I could not make requests to the server as HTTP was disabled. I have also created the repository for the Android application using Kotlin."
            },
            new PfcUpdate
            {
                Date          = new DateOnly(2026, 04, 11),
                Title         = "Despliegue en Azure e inicio de desarrollo nativo (iOS y Android)",
                TitleEn       = "Azure deployment and start of native development (iOS and Android)",
                Description   = "Se ha implementado con éxito la autenticación de Microsoft y la configuración de seguridad base. " +
                                "Actualmente, existe una discrepancia en la persistencia de sesión entre el entorno local y Azure, " +
                                "impidiendo que el usuario se mantenga logueado tras el despliegue. Se está trabajando en ajustar " +
                                "la gestión de contextos para producción. Paralelamente, con el fin de optimizar la experiencia móvil, " +
                                "hemos inicializado los repositorios para las aplicaciones nativas en Swift (iOS) y Kotlin (Android).",
                DescriptionEn = "Microsoft authentication and base security configuration have been successfully implemented. " +
                                "There is currently a session persistence discrepancy between the local environment and Azure, " +
                                "preventing users from staying logged in after deployment. Work is underway to adjust context " +
                                "management for production. In parallel, to optimize the mobile experience, repositories have " +
                                "been initialized for the native apps in Swift (iOS) and Kotlin (Android)."
            },
            new PfcUpdate
            {
                Date          = new DateOnly(2026, 04, 07),
                Title         = "Inicio de sesión con Microsoft",
                TitleEn       = "Microsoft sign-in",
                Description   = "Finalizada la implementación de Microsoft Auth y la configuración de seguridad. Se completó el diseño " +
                                "del Dashboard y se unificó el sistema de autorización para corregir errores de redundancia. Próximo objetivo: " +
                                "desarrollo de los flujos de registro e inicio de sesión local.",
                DescriptionEn = "Microsoft Auth implementation and security configuration finalized. Dashboard design completed and authorization system unified to fix redundancy errors. Next goal: develop local registration and login flows."
            },
            new PfcUpdate
            {
                Date          = new DateOnly(2026, 03, 29),
                Title         = "Autenticación, middleware y conexión a base de datos",
                TitleEn       = "Authentication, middleware and database connection",
                Description   = "Esta semana he estructurado los dos flujos de login (email/contraseña y Microsoft), " +
                                "configurado el JWT, los middlewares de excepciones globales y establecido la conexión " +
                                "con Azure SQL. Próximos pasos: integrar Azure Entra ID (AD) y conectar todo con el frontend en Blazor.",
                DescriptionEn = "This week I structured the two login flows (email/password and Microsoft), configured the JWT, global exception middlewares and established the connection with Azure SQL. Next steps: integrate Azure Entra ID (AD) and connect everything with the Blazor frontend."
            },
            new PfcUpdate
            {
                Date          = new DateOnly(2026, 03, 23),
                Title         = "Incio de proyecto",
                TitleEn       = "Project kickoff",
                Description   = "Hoy he empezado este nuevo proyecto, lo primero que he hecho ha sido encontrar la idea del proyecto, ver si es economicamente rentable para poder despleg" +
                                "arlo y ver la arquitectura de la aplicacion",
                DescriptionEn = "I started this new project today. The first steps were to define the project idea, assess its economic viability for deployment and plan the application architecture."
            }
        ];
    }
}
