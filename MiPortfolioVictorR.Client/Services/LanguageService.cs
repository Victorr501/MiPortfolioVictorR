namespace MiPortfolioVictorR.Client.Services
{
    public class LanguageService
    {
        public string CurrentLanguage { get; private set; } = "es";
        public bool IsEnglish => CurrentLanguage == "en";
        public event Action? OnLanguageChanged;

        public void SetLanguage(string lang)
        {
            if (CurrentLanguage == lang) return;
            CurrentLanguage = lang;
            OnLanguageChanged?.Invoke();
        }

        public string Get(string es, string? en) =>
            IsEnglish && !string.IsNullOrWhiteSpace(en) ? en : es;
    }
}
