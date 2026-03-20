using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPortfolioVictorR.Shared.Models
{
    public class Skill
    {
        public string Name { get; set; }
        public string Category { get; set; } = string.Empty;
        public string IconUrl { get; set; } = string.Empty;
        public bool IsLearning { get; set; }
    }
}
