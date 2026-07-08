using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class ExperienceService
    {
        public List<WorkExperience> GetAll() =>
        [
            new WorkExperience
            {
                Period   = "Enero 2026 – Junio 2026",
                Role     = "Desarrollador Junior – Tecnologías Microsoft",
                RoleEn   = "Junior Developer – Microsoft Technologies",
                Company  = "Agralamo",
                Location = "Teletrabajo",
                Type     = ExperienceType.Developer,
                Descriptions =
                [
                    "Diseño y supervisión de arquitectura cliente-servidor para un Agente Comercial con IA, utilizando .NET 8.0 y servicios cognitivos de Azure con persistencia en SQL.",
                    "Desarrollo de middleware robusto en C# (.NET 10) para la integración de Dynamics 365 Business Central con servidores SFTP, garantizando alta disponibilidad en Azure.",
                    "Liderazgo en la automatización de flujos de trabajo críticos mediante Power Automate y SharePoint (Proyecto Latero), digitalizando procesos manuales de gestión documental.",
                    "Implementación de soluciones backend para el intercambio seguro de datos de gran volumen mediante protocolos SFTP/SSH y APIs de Business Central.",
                    "Gestión del ciclo de vida de aplicaciones en la nube utilizando Azure App Services, JSON/XML y control de versiones con Git.",
                    "Desarrollo activo de extensiones y actualizaciones personalizadas sobre la plataforma Dynamics 365 Business Central, adaptando funcionalidades del ERP a los procesos específicos del negocio."
                ],
                DescriptionsEn =
                [
                    "Design and supervision of a client-server architecture for a Commercial AI Agent, using .NET 8.0 and Azure cognitive services with SQL persistence.",
                    "Development of robust C# (.NET 10) middleware for integrating Dynamics 365 Business Central with SFTP servers, ensuring high availability on Azure.",
                    "Leadership in the automation of critical workflows using Power Automate and SharePoint (Latero Project), digitizing manual document management processes.",
                    "Implementation of backend solutions for secure, high-volume data exchange using SFTP/SSH protocols and Business Central APIs.",
                    "Management of the cloud application lifecycle using Azure App Services, JSON/XML and version control with Git.",
                    "Active development of custom extensions and updates on the Dynamics 365 Business Central platform, adapting ERP functionality to specific business processes."
                ]
            },
            new WorkExperience
            {
                Period   = "Septiembre 2025 – Enero 2026",
                Role     = "Desarrollador Junior (Prácticas)",
                RoleEn   = "Junior Developer (Internship)",
                Company  = "Agralamo",
                Location = "Teletrabajo",
                Type     = ExperienceType.Developer,
                Descriptions =
                [
                    "Creación de un SGA integrado con Business Central y un sistema de Registro Horario (Peris).",
                    "Stack: C#, Blazor WASM, SQL, Docker/Nginx.",
                    "Experiencia en gestión logística, APIs OAuth2, flujos administrativos y auditoría."
                ],
                DescriptionsEn =
                [
                    "Creation of a WMS integrated with Business Central and a Time Tracking system (Peris).",
                    "Stack: C#, Blazor WASM, SQL, Docker/Nginx.",
                    "Experience in logistics management, OAuth2 APIs, administrative workflows and auditing."
                ]
            },
            new WorkExperience
            {
                Period   = "Junio 2026 – Septiembre 2026",
                Role     = "Vendedor",
                RoleEn   = "Sales Associate",
                Company  = "IKEA",
                Location = "Madrid",
                Type     = ExperienceType.Generic,
                Descriptions =
                [
                    "Asistente en cajas y atención al cliente"
                ],
                DescriptionsEn =
                [
                    "Cashier and customer service assistant"
                ]
            },
            new WorkExperience
            {
                Period   = "Junio 2025 – Septiembre 2025",
                Role     = "Vendedor",
                RoleEn   = "Sales Associate",
                Company  = "IKEA",
                Location = "Madrid",
                Type     = ExperienceType.Generic,
                Descriptions =
                [
                    "Reposición de puntos requeridos en tienda y atención al consumidor."
                ],
                DescriptionsEn =
                [
                    "Stock replenishment at required store locations and customer service."
                ]
            },
            new WorkExperience
            {
                Period   = "Marzo 2025 – Abril 2025",
                Role     = "Mozo de almacén",
                RoleEn   = "Warehouse Operative",
                Company  = "Tamdis",
                Location = "Madrid",
                Type     = ExperienceType.Generic,
                Descriptions =
                [
                    "Mozo de almacén de muebles con uso de transpalé."
                ],
                DescriptionsEn =
                [
                    "Furniture warehouse operative with pallet truck operation."
                ]
            },
            new WorkExperience
            {
                Period   = "Marzo 2023 – Junio 2023",
                Role     = "Dependiente zona electrónica",
                RoleEn   = "Electronics Sales Assistant",
                Company  = "Carrefour",
                Location = "Madrid",
                Type     = ExperienceType.Generic,
                Descriptions =
                [
                    "Atención directa al público, gestión de inventario de manera proactiva.",
                    "Altas habilidades comunicativas."
                ],
                DescriptionsEn =
                [
                    "Direct customer service, proactive inventory management.",
                    "Strong communication skills."
                ]
            },
            new WorkExperience
            {
                Period   = "Septiembre 2020 – Junio 2025",
                Role     = "Animador juvenil y colaborador en acciones benéficas",
                RoleEn   = "Youth Animator and Charity Volunteer",
                Company  = "Asociación / Centro Juvenil",
                Location = "Madrid",
                Type     = ExperienceType.Volunteer,
                Descriptions =
                [
                    "Organización de actividades lúdicas y educativas para niños y adolescentes.",
                    "Planificación de eventos, campamentos de verano y fomento de valores de compañerismo."
                ],
                DescriptionsEn =
                [
                    "Organization of recreational and educational activities for children and teenagers.",
                    "Planning of events, summer camps and promoting values of teamwork and companionship."
                ]
            }
        ];

        public List<WorkExperience> GetByType(ExperienceType type) =>
            GetAll().Where(e => e.Type == type).ToList();
    }
}
