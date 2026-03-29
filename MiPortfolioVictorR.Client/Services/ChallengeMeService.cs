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
            }
        ];
    }
}
