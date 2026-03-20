using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class EducationService
    {
        public List<Education> GetEducation() => [
            new Education
            {
                Period   = "2023 – 2025",
                Title    = "Grado Superior en Desarrollo de Aplicaciones Multiplataforma",
                Center   = "IES Enrique Tierno Galván",
                Location = "Madrid, España"
            },
            new Education
            {
                Period   = "2021 – 2023",
                Title    = "Grado Medio en Sistemas Microinformáticos y Redes",
                Center   = "Salesianos Ciudad de los Muchachos",
                Location = "Madrid, España"
            },
            new Education
            {
                Period   = "2017 – 2021",
                Title    = "Educación Secundaria Obligatoria (ESO)",
                Center   = "Salesianos Ciudad de los Muchachos",
                Location = "Madrid, España"
            }
        ];

        public List<Course> GetCourses() => [
            new Course { Name = "Prompting responsable: maximiza la IA en tu negocio", Platform = "Santander Open Academy", CertificateCode = "OA-2025-1027001886068" },
            new Course { Name = "Copilot",                                              Platform = "Santander Open Academy", CertificateCode = "OA-2025-1023001873792" },
            new Course { Name = "Cursor con Python: desarrollo inteligente con IA",     Platform = "Santander Open Academy", CertificateCode = "OA-2025-1023001873028" },
            new Course { Name = "Python",                                               Platform = "Santander Open Academy", CertificateCode = "OA-2025-1024001877514" },
            new Course { Name = "Curso de Iniciación al Desarrollo con IA",             Platform = "Big School" },

            // Cursos de Microsoft
            new Course {Name     = "Expediente completo Microsoft Learn", Platform = "Microsoft Learn", Url      = "https://learn.microsoft.com/es-es/users/vctorrubnrubio-7324/transcript/deq20c1q5klpg4n"},
            new Course { Name = "Creación de aplicaciones en .NET con C#",                                          Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/vthujkbm" },
            new Course { Name = "Escribir el primer código con C# (parte 1)",                                       Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/DUA48YPJ?sharingId=7BA3BE6C81F7F8" },
            new Course { Name = "Creación y ejecución de aplicaciones de consola de C# sencillas (parte 2)",        Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/FQL7EMVX?sharingId=7BA3BE6C81F7F8" },
            new Course { Name = "Adición de lógica a aplicaciones de consola de C# (parte 3)",                     Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/AK99ZC57?sharingId=7BA3BE6C81F7F8" },
            new Course { Name = "Trabajo con datos de variables en aplicaciones de consola de C# (parte 4)",        Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/KCATYSUB?sharingId=7BA3BE6C81F7F8" },
            new Course { Name = "Creación de métodos en aplicaciones de consola de C# (parte 5)",                   Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/9RBB76ZU?sharingId=7BA3BE6C81F7F8" },
            new Course { Name = "Depuración de aplicaciones de consola de C# (parte 6)",                           Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/AKUNJSM7?sharingId=7BA3BE6C81F7F8" },
            new Course { Name = "Comprender los aspectos básicos de ASP.NET Core",                                  Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/9RDHDWKU?sharingId=7BA3BE6C81F7F8" },
            new Course { Name = "Compilación de aplicaciones web con ASP.NET Core para principiantes",              Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/ZD8QVFS2?sharingId=7BA3BE6C81F7F8" },
            new Course { Name = "Creación de aplicaciones y servicios nativos en la nube con .NET y ASP.NET Core", Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/B9ZLCCRD?sharingId=7BA3BE6C81F7F8" },
            new Course { Name = "Introducción a la infraestructura en la nube: Conceptos de la nube",               Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/7BHGYNDZ?sharingId=7BA3BE6C81F7F8" },
            new Course { Name = "Introducción a la infraestructura en la nube: Arquitectura y servicios de Azure",  Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/AK3Y6TA7?sharingId=7BA3BE6C81F7F8" },
            new Course { Name = "Introducción a la infraestructura en la nube: Administración y gobernanza de Azure", Platform = "Microsoft Learn", Url = "https://learn.microsoft.com/api/achievements/share/es-es/VctorRubnRubio-7324/AK3Y9BN7?sharingId=7BA3BE6C81F7F8" },
        ];
    }
}
