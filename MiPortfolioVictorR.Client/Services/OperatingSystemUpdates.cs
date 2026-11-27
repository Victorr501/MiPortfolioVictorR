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
            },
            new PfcUpdate
            {
                Date = new DateOnly(2026, 11, 27),
                Title = "Estructurar el proyecto y comprender la complejidad",
                TitleEn = "Structure the project and understand the complexity",
                Description = "Construir un sistema operativo desde cero es como escalar el Everest. Tras investigar cómo abordar la implementación, vi que necesitaba asentar muchos conceptos internos y de lenguaje. Por eso, he decidido centrarme primero en aprender C y Ensamblador, además de estudiar 'Sistemas Operativos Modernos' (3.ª ed.) de Andrew S. Tanenbaum.",
                DescriptionEn = "Building an OS from scratch feels like climbing Mount Everest. After researching how to implement the project, I realized I needed a stronger foundation in low-level internals and systems languages. Because of that, I decided to focus on learning C and Assembly while studying Andrew S. Tanenbaum's 'Modern Operating Systems' (3rd Ed.)."
            },

        ];
    }
}
