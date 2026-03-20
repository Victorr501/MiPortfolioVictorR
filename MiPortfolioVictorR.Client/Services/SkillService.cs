using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class SkillService
    {
        private const string DevIcons = "https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons";

        public List<Skill> GetSkills() =>
        [
            // Frontend
            new Skill { Name = "HTML",       Category = "Frontend",    IconUrl = $"{DevIcons}/html5/html5-original.svg" },
            new Skill { Name = "CSS",        Category = "Frontend",    IconUrl = $"{DevIcons}/css3/css3-original.svg" },
            new Skill { Name = "Blazor",     Category = "Frontend",    IconUrl = $"{DevIcons}/blazor/blazor-original.svg" },
            new Skill { Name = "JavaScript", Category = "Frontend",    IconUrl = $"{DevIcons}/javascript/javascript-original.svg" },
            // Backend
            new Skill { Name = "C#",         Category = "Backend",     IconUrl = $"{DevIcons}/csharp/csharp-original.svg" },
            new Skill { Name = "Python",     Category = "Backend",     IconUrl = $"{DevIcons}/python/python-original.svg" },
            new Skill { Name = "Java",       Category = "Backend",     IconUrl = $"{DevIcons}/java/java-original.svg" },
            new Skill { Name = "FastAPI",    Category = "Backend",     IconUrl = $"{DevIcons}/fastapi/fastapi-original.svg" },
            new Skill { Name = "MySQL",      Category = "Backend",     IconUrl = $"{DevIcons}/mysql/mysql-original.svg" },
            new Skill { Name = "MongoDB",    Category = "Backend",     IconUrl = $"{DevIcons}/mongodb/mongodb-original.svg" },
            new Skill { Name = "Docker",     Category = "Backend",     IconUrl = $"{DevIcons}/docker/docker-original.svg" },
            // Herramientas
            new Skill { Name = "GitHub",         Category = "Herramientas", IconUrl = $"{DevIcons}/github/github-original.svg" },
            new Skill { Name = "Git",            Category = "Herramientas", IconUrl = $"{DevIcons}/git/git-original.svg" },
            new Skill { Name = "VS Code",        Category = "Herramientas", IconUrl = $"{DevIcons}/vscode/vscode-original.svg" },
            new Skill { Name = "Visual Studio",  Category = "Herramientas", IconUrl = $"{DevIcons}/visualstudio/visualstudio-plain.svg" },
            new Skill { Name = "IntelliJ",       Category = "Herramientas", IconUrl = $"{DevIcons}/intellij/intellij-original.svg" },
            new Skill { Name = "DBeaver",        Category = "Herramientas", IconUrl = $"{DevIcons}/dbeaver/dbeaver-original.svg" },
            new Skill { Name = "Azure DevOps",   Category = "Herramientas", IconUrl = $"{DevIcons}/azuredevops/azuredevops-original.svg" },
            new Skill { Name = "SQL Server",     Category = "Herramientas", IconUrl = $"{DevIcons}/azuresqldatabase/azuresqldatabase-original.svg" },
            // Aprendiendo
            new Skill { Name = "Azure", Category = "Aprendiendo", IconUrl = $"{DevIcons}/azure/azure-original.svg", IsLearning = true },
        ];

        public List<string> GetCategories() =>
            GetSkills().Select(s => s.Category).Distinct().ToList();

        public List<Skill> GetByCategory(string category) =>
            GetSkills().Where(s => s.Category == category).ToList();
    }
}
