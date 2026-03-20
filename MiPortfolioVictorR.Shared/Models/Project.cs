using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPortfolioVictorR.Shared.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string GitHubUrl { get; set; } = string.Empty;
        public string? GitHubUrlBackend { get; set; }
        public string? LiveUrl { get; set; }
        public string? YouTubeUrl { get; set; }
        public string? ImageUrl { get; set; }
        public List<string> Tags { get; set; }
        public bool IsFeatured { get; set; }
    }
}
