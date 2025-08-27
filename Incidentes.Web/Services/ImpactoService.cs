using Incidentes.Web.Entities;
using Incidentes.Web.Interfaces;
using System.Net.Http.Json;

namespace Incidentes.Web.Services
{
    public class ImpactoService : IImpactoService
    {
        private readonly HttpClient _httpClient;

        public ImpactoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Impacto>> GetImpactosAsync()
        {
            var url = "api/impacto";
            var response = await _httpClient.GetFromJsonAsync<List<Impacto>>(url);
            return response ?? new List<Impacto>();
        }
    }
}
