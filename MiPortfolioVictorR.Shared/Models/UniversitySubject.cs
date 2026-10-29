namespace MiPortfolioVictorR.Shared.Models
{
    public class UniversitySubject
    {
        public string Name { get; set; } = string.Empty;
        public string NameEn { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DescriptionEn { get; set; } = string.Empty;
        public int? Year { get; set; }
        public int? Semester { get; set; }
        public string? Grade { get; set; }
        public bool IsRecognized { get; set; }
        public bool InProgress { get; set; }
    }
}
