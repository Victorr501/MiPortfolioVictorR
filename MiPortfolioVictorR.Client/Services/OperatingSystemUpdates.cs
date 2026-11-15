using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public static class OperatingSystemUpdates
    {
        // Añade aquí una entrada con su fecha cada vez que se actualice el proyecto.
        public static List<PfcUpdate> GetUpdates() =>
        [
            new PfcUpdate
            {
                Date = new DateOnly(2026, 11, 15),
                Title = "Primer borrador del proyecto",
                TitleEn = "First project draft",
                Description = "Definición inicial de la visión, las tecnologías previstas, la documentación y la hoja de ruta de OS.",
                DescriptionEn = "Initial definition of the vision, planned technologies, documentation and roadmap for OS."
            }
        ];
    }
}
