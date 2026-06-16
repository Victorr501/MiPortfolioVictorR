using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class SkillService
    {
        private const string DevIcons = "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons";

        public List<Skill> GetSkills() =>
        [            // Desarrollo web y APIs
            new Skill { Name = "HTML",       Category = "Desarrollo Web y APIs",    IconUrl = $"{DevIcons}/html5/html5-original.svg" },
            new Skill { Name = "CSS",        Category = "Desarrollo Web y APIs",    IconUrl = $"{DevIcons}/css3/css3-original.svg" },
            new Skill { Name = "JavaScript", Category = "Desarrollo Web y APIs",    IconUrl = $"{DevIcons}/javascript/javascript-original.svg" },
            new Skill { Name = "React",     Category = "Desarrollo Web y APIs",    IconUrl = $"{DevIcons}/react/react-original.svg" },
            new Skill { Name = "C#",         Category = "Desarrollo Web y APIs",     IconUrl = $"{DevIcons}/csharp/csharp-original.svg" },
            new Skill { Name = "ASP.NET Core", Category = "Desarrollo Web y APIs",     IconUrl = $"{DevIcons}/dotnetcore/dotnetcore-original.svg" },
            new Skill { Name = "Python",     Category = "Desarrollo Web y APIs",     IconUrl = $"{DevIcons}/python/python-original.svg" },
            new Skill { Name = "FastAPI",    Category = "Desarrollo Web y APIs",     IconUrl = $"{DevIcons}/fastapi/fastapi-original.svg" },
            new Skill { Name = "Java",       Category = "Desarrollo Web y APIs",     IconUrl = $"{DevIcons}/java/java-original.svg" },
            new Skill { Name = "MySQL",      Category = "Desarrollo Web y APIs",     IconUrl = $"{DevIcons}/mysql/mysql-original.svg" },
            new Skill { Name = "MongoDB",    Category = "Desarrollo Web y APIs",     IconUrl = $"{DevIcons}/mongodb/mongodb-original.svg" },

            // Software y Sistemas
            new Skill { Name = "C++",    Category = "Software y Sistemas",     IconUrl = $"{DevIcons}/cplusplus/cplusplus-original.svg" },

            // Herramientas
            new Skill { Name = "GitHub",         Category = "Herramientas", IconUrl = $"{DevIcons}/github/github-original.svg" },
            new Skill { Name = "Git",            Category = "Herramientas", IconUrl = $"{DevIcons}/git/git-original.svg" },
            new Skill { Name = "VS Code",        Category = "Herramientas", IconUrl = $"{DevIcons}/vscode/vscode-original.svg" },
            new Skill { Name = "Visual Studio",  Category = "Herramientas", IconUrl = $"{DevIcons}/visualstudio/visualstudio-plain.svg" },
            new Skill { Name = "IntelliJ",       Category = "Herramientas", IconUrl = $"{DevIcons}/intellij/intellij-original.svg" },
            new Skill { Name = "DBeaver",        Category = "Herramientas", IconUrl = $"{DevIcons}/dbeaver/dbeaver-original.svg" },
            new Skill { Name = "Azure DevOps",   Category = "Herramientas", IconUrl = $"{DevIcons}/azuredevops/azuredevops-original.svg" },
            new Skill { Name = "SQL Server",     Category = "Herramientas", IconUrl = $"{DevIcons}/azuresqldatabase/azuresqldatabase-original.svg" },
            new Skill { Name = "Azure", Category = "Herramientas", IconUrl = $"{DevIcons}/azure/azure-original.svg"},
            new Skill { Name = "Xcode", Category = "Herramientas", IconUrl = $"{DevIcons}/xcode/xcode-original.svg" },
            new Skill { Name = "Docker",     Category = "Herramientas",     IconUrl = $"{DevIcons}/docker/docker-original.svg" },

            // Aprendiendo
            new Skill {Name = "SVG versions", Category = "Aprendiendo", IconUrl = $"{DevIcons}/githubactions/githubactions-original.svg", IsLearning = true },
            new Skill {Name = "Swift", Category = "Aprendiendo", IconUrl = $"{DevIcons}/swift/swift-original.svg"},
            new Skill {Name = "Kotlin", Category = "Aprendiendo", IconUrl = $"{DevIcons}/kotlin/kotlin-original.svg"},
            new Skill {Name = "C", Category = "Aprendiendo", IconUrl = $"{DevIcons}/c/c-original.svg"},
        ];

        public List<string> GetCategories() =>
            GetSkills().Select(s => s.Category).Distinct().ToList();

        public List<Skill> GetByCategory(string category) =>
            GetSkills().Where(s => s.Category == category).ToList();
    }
}
