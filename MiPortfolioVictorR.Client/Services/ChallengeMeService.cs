using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class ChallengeMeService
    {
        public List<PfcUpdate> GetUpdates() =>
        [
            new PfcUpdate
            {
                Date        = new DateOnly(2026, 03, 23),
                Title       = "Incio de proyecto",
                Description = "Hoy he empezado este nuevo proyecto, lo primero que he hecho ha sido encontrar la idea del proyecto, ver si es economicamente rentable para poder despleg" +
                "arlo y ver la arquitectura de la aplicacion"
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
                Date        = new DateOnly(2026, 04, 07),
                Title       = "Inicio de sesión con Microsoft",
                Description = "Finalizada la implementación de Microsoft Auth y la configuración de seguridad. Se completó el diseño " +
                              "del Dashboard y se unificó el sistema de autorización para corregir errores de redundancia. Próximo objetivo: " +
                              "desarrollo de los flujos de registro e inicio de sesión local."
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
                Date = new DateOnly(2026, 04, 13),
                Title = "Solucion de la discrepancia del entorno y creacion de la aplicacion para android",
                Description = "Ya he terminado de solucionar el problema en la autenticacion, al final lo que he tenido que hacer es usar localstorage en vez de la cookes devido a que una vez arrancada la pestaña yo no podia hacer una peticion al servidor ya que el http estaba desabilitado. A ademas he creado ya el repostirio para la aplicacion en Android usando Kotlin"
            }
        ];
    }
}
