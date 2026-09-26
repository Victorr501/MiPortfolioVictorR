using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class LocalAIService
    {
        // Al estar el proyecto recién iniciado, devolvemos una lista vacía de actualizaciones.
        // La vista ya está preparada para mostrar el mensaje "Aún sin actualizaciones".
        public List<PfcUpdate> GetUpdates() => 
        [
            new PfcUpdate
            {
                Date           = new DateOnly(2025, 11, 12),
                Title          = "Proyecto finalizado y próximos pasos",
                TitleEn        = "Project completed and next steps",
                Description    = "Desarrollo de Trackify finalizado. La aplicación incluye todas las funcionalidades principales: registro de usuarios, creación de hábitos, seguimiento del progreso y gestor de racha completamente funcional. Las notificaciones automáticas no se implementaron por incompatibilidades técnicas.",
                DescriptionEn  = "Trackify development completed. The app includes all main features: user registration, habit creation, progress tracking and a fully functional streak manager. Automatic notifications were not implemented due to technical incompatibilities."
            },
        ];
    }
}