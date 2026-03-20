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
                    "Diseño y supervisión de arquitectura cliente-servidor para un Agente Comercial con IA, utilizando .NET 8.0 y servicios cognitivos de Azure con persistencia en SQL.",
                    "Desarrollo de middleware robusto en C# (.NET 10) para la integración de Dynamics 365 Business Central con servidores SFTP, garantizando alta disponibilidad en Azure.",
                    "Liderazgo en la automatización de flujos de trabajo críticos mediante Power Automate y SharePoint (Proyecto Latero), digitalizando procesos manuales de gestión documental.",
                    "Implementación de soluciones backend para el intercambio seguro de datos de gran volumen mediante protocolos SFTP/SSH y APIs de Business Central.",
                    "Gestión del ciclo de vida de aplicaciones en la nube utilizando Azure App Services, JSON/XML y control de versiones con Git."
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
