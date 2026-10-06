using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class LocalAIService
    {
        public List<PfcUpdate> GetUpdates() =>
        [
            new PfcUpdate
            {
                Date           = new DateOnly(2026, 9, 28),
                Title          = "Arranque del proyecto: Ideas, Configuración del entorno, Codificación basica y documentacion",
                TitleEn        = "Project kickoff: Ideas, Environment setup, Basic coding and documentation",
                Description    = "Definición de la hoja de ruta y la arquitectura limpia. Configuración del entorno local con soporte GPU (CUDA) y despliegue de MongoDB en Docker. Implementación del motor base de IA usando llama-cpp-python, conexión a base de datos y creación del orquestador principal de enrutamiento (CLI/API). Redacción de documentación técnica profesional.",
                DescriptionEn  = "Definition of the roadmap and clean architecture. Local environment setup with GPU support (CUDA) and MongoDB deployment via Docker. Implementation of the core AI engine using llama-cpp-python, database connection, and creation of the main routing orchestrator (CLI/API). Writing of professional technical documentation."
            },
        ];
    }
}