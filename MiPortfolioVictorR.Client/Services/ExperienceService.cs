using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class ExperienceService
    {
        public List<WorkExperience> GetAll() =>
        [
            new WorkExperience
            {
                Period   = "Enero 2026 – Presente",
                Role     = "Desarrollador Junior – Tecnologías Microsoft",
                Company  = "Agralamo",
                Location = "Teletrabajo",
                Type     = ExperienceType.Developer,
                Descriptions =
                [
                    "Automatización de procesos con Power Automate y SharePoint (Latero).",
                    "Integración de Business Central con SFTP mediante middleware en C# desplegado en Azure.",
                    "Diseño y desarrollo de un middleware en C# (.NET 8 Isolated) en Azure Functions para integrar Dynamics 365 Business Central con servidores SFTP."
                ]
            },
            new WorkExperience
            {
                Period   = "Septiembre 2025 – Enero 2026",
                Role     = "Desarrollador Junior (Prácticas)",
                Company  = "Agralamo",
                Location = "Teletrabajo",
                Type     = ExperienceType.Developer,
                Descriptions =
                [
                    "Creación de un SGA integrado con Business Central y un sistema de Registro Horario (Peris).",
                    "Stack: C#, Blazor WASM, SQL, Docker/Nginx.",
                    "Experiencia en gestión logística, APIs OAuth2, flujos administrativos y auditoría."
                ]
            },
            new WorkExperience
            {
                Period   = "Junio 2025 – Septiembre 2025",
                Role     = "Vendedor",
                Company  = "IKEA",
                Location = "Madrid",
                Type     = ExperienceType.Generic,
                Descriptions =
                [
                    "Reposición de puntos requeridos en tienda y atención al consumidor."
                ]
            },
            new WorkExperience
            {
                Period   = "Marzo 2025 – Abril 2025",
                Role     = "Mozo de almacén",
                Company  = "Tamdis",
                Location = "Madrid",
                Type     = ExperienceType.Generic,
                Descriptions =
                [
                    "Mozo de almacén de muebles con uso de transpalé."
                ]
            },
            new WorkExperience
            {
                Period   = "Marzo 2023 – Junio 2023",
                Role     = "Dependiente zona electrónica",
                Company  = "Carrefour",
                Location = "Madrid",
                Type     = ExperienceType.Generic,
                Descriptions =
                [
                    "Atención directa al público, gestión de inventario de manera proactiva.",
                    "Altas habilidades comunicativas."
                ]
            },
            new WorkExperience
            {
                Period   = "Septiembre 2020 – Junio 2025",
                Role     = "Animador juvenil y colaborador en acciones benéficas",
                Company  = "Asociación / Centro Juvenil",
                Location = "Madrid",
                Type     = ExperienceType.Volunteer,
                Descriptions =
                [
                    "Organización de actividades lúdicas y educativas para niños y adolescentes.",
                    "Planificación de eventos, campamentos de verano y fomento de valores de compañerismo."
                ]
            }
        ];

        public List<WorkExperience> GetByType(ExperienceType type) =>
            GetAll().Where(e => e.Type == type).ToList();
    }
}
