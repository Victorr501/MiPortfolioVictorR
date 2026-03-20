using System.Net.Http.Json;
using MiPortfolioVictorR.Shared.Constants;
using MiPortfolioVictorR.Shared.Models;

namespace MiPortfolioVictorR.Client.Services
{
    public class ContactService(HttpClient http)
    {
        public async Task<bool> SendAsync(ContactForm form)
        {
            if (string.IsNullOrWhiteSpace(AppSettings.FormspreeEndpoint))
                return false;

            var response = await http.PostAsJsonAsync(AppSettings.FormspreeEndpoint, form);
            return response.IsSuccessStatusCode;
        }
    }
}
