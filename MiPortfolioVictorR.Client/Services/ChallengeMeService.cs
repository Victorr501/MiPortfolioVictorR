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
        ];
    }
}
