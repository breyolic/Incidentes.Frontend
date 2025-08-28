using Incidentes.Web.Entities;
using Incidentes.Web.Interfaces;
using System.Net.Http.Json;

namespace Incidentes.Web.Services
{
    public class PrioridadService : IPrioridadService
    {
        private readonly HttpClient _httpClient;
        public PrioridadService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Prioridad>> GetPrioridadesAsync()
        {
            var url = "api/prioridad";
            var response = await _httpClient.GetFromJsonAsync<List<Prioridad>>(url);
            return response ?? new List<Prioridad>();
        }
    }
}
