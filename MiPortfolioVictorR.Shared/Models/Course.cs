using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPortfolioVictorR.Shared.Models
{
    public class Course
    {
        public string Name { get; set; } = string.Empty;
        public string Platform { get; set; } = string.Empty;
        public string? CertificateCode { get; set; }
        public string? Url { get; set; }
    }
}
