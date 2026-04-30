using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class ChallengeMeService
    {
        public List<PfcUpdate> GetUpdates() =>
        [
            new PfcUpdate
            {
                Date = new DateOnly(2026, 05, 02),
                Title = "Documentación completa del proyecto y arquitectura definida",
                Description = "He completado la documentación técnica de ChallengMe!, definiendo la arquitectura completa por capas para la API, Web (Blazor), iOS (SwiftUI) y Android (Jetpack Compose). También quedan definidos la paleta de color, tipografía, endpoints con sus modelos de request y response, estructura de base de datos SQL y Cosmos DB, plan de tests unitarios e integración, y el roadmap de publicación con sus costes reales. Toda esta base documental es la que permite mantener cuatro plataformas con coherencia siendo un único desarrollador."
            },
            new PfcUpdate
            {
                Date = new DateOnly(2026, 04, 30),
                Title = "Suite de tests completa para la API — 29/29 en verde",
                Description = "Hoy he implementado la suite de tests completa para ChallengMe! API. Tests unitarios de AuthService cubriendo login con email, registro y login con Microsoft usando Moq para aislar dependencias. Tests unitarios de UsuarioRepository con SQLite en memoria para no tocar Azure SQL. Tests unitarios de AzureAdService simulando respuestas HTTP de Microsoft con un FakeHttpMessageHandler. Y tests de integración del AuthController levantando la API completa en memoria con WebApplicationFactory y verificando que el ExceptionMiddleware convierte las excepciones en los códigos HTTP correctos. Stack de testing: xUnit + Moq + FluentAssertions + SQLite in-memory."
            },
            new PfcUpdate
            {
                Date = new DateOnly(2026, 04, 24),
                Title = "Icono diseñado a mano e implementado en web y móvil",
                Description = "He diseñado el icono de ChallengMe! desde cero a mano, digitalizándolo e integrándolo tanto en la aplicación web como en las apps móviles de iOS y Android. Un detalle de identidad visual que le da carácter propio al proyecto más allá del código."
            },
            new PfcUpdate
            {
                Date = new DateOnly(2026, 04, 22),
                Title = "Desarrollo de login en Android, diseño de logo y planificación de escalabilidad",
                Description = "Ya he desarrollado el login y registro en ChallengMe para Android usando Kotlin. Además, he terminado de diseñar el logo de la aplicación. Los siguientes pasos serán integrar este logo en las interfaces, investigar el proceso de publicación en la AppStore y PlayStore, y desarrollar los tests de la API, una tarea invisible para el usuario pero fundamental para asegurar la escalabilidad del proyecto."
            },
            new PfcUpdate
            {
                Date = new DateOnly(2026, 04, 19),
                Title = "Desarrollo inicial de iOS completado y planificación para Android",
                Description = "Ya he desarrollado el login, registro y la pantalla principal de mi proyecto ChallengMe! en iOS. Está funcionando perfectamente, usando el mismo servidor que la página web. Lo próximo que haré será desarrollar la versión para Android usando Kotlin (manteniendo las mismas funciones), crear el icono de la aplicación y publicar ambas versiones para que las podáis ir descargando y probando."
            },
            new PfcUpdate
            {
                Date = new DateOnly(2026, 04, 13),
                Title = "Solucion de la discrepancia del entorno y creacion de la aplicacion para android",
                Description = "Ya he terminado de solucionar el problema en la autenticacion, al final lo que he tenido que hacer es usar localstorage en vez de la cookes devido a que una vez arrancada la pestaña yo no podia hacer una peticion al servidor ya que el http estaba desabilitado. A ademas he creado ya el repostirio para la aplicacion en Android usando Kotlin"
            },
            new PfcUpdate
            {
                Date = new DateOnly(2026, 04, 11),
                Title = "Despliegue en Azure e inicio de desarrollo nativo (iOS y Android)",
                Description = "Se ha implementado con éxito la autenticación de Microsoft y la configuración de seguridad base. " +
                            "Actualmente, existe una discrepancia en la persistencia de sesión entre el entorno local y Azure, " +
                            "impidiendo que el usuario se mantenga logueado tras el despliegue. Se está trabajando en ajustar " +
                            "la gestión de contextos para producción. Paralelamente, con el fin de optimizar la experiencia móvil, " +
                            "hemos inicializado los repositorios para las aplicaciones nativas en Swift (iOS) y Kotlin (Android)."
            },
            new PfcUpdate
            {
                Date        = new DateOnly(2026, 04, 07),
                Title       = "Inicio de sesión con Microsoft",
                Description = "Finalizada la implementación de Microsoft Auth y la configuración de seguridad. Se completó el diseño " +
                              "del Dashboard y se unificó el sistema de autorización para corregir errores de redundancia. Próximo objetivo: " +
                              "desarrollo de los flujos de registro e inicio de sesión local."
            },
            new PfcUpdate
            {
                Date        = new DateOnly(2026, 03, 29),
                Title       = "Autenticación, middleware y conexión a base de datos",
                Description = "Esta semana he estructurado los dos flujos de login (email/contraseña y Microsoft), " +
                              "configurado el JWT, los middlewares de excepciones globales y establecido la conexión " +
                              "con Azure SQL. Próximos pasos: integrar Azure Entra ID (AD) y conectar todo con el frontend en Blazor."
            },
            new PfcUpdate
            {
                Date        = new DateOnly(2026, 03, 23),
                Title       = "Incio de proyecto",
                Description = "Hoy he empezado este nuevo proyecto, lo primero que he hecho ha sido encontrar la idea del proyecto, ver si es economicamente rentable para poder despleg" +
                "arlo y ver la arquitectura de la aplicacion"
            }
        ];
    }
}