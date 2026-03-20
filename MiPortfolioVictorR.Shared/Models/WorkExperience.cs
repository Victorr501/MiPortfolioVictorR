using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiPortfolioVictorR.Shared.Models
{
    public class WorkExperience
    {
        public string Period { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public List<string> Descriptions { get; set; } = [];
        public ExperienceType Type {  get; set; }
    }

    public enum ExperienceType
    {
        Developer,
        Generic,
        Volunteer,
    }
}
