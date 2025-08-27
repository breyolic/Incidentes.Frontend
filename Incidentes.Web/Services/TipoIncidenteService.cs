using Incidentes.Web.Entities;
using Incidentes.Web.Interfaces;
using System.Net.Http.Json;

namespace Incidentes.Web.Services
{
    public class TipoIncidenteService : ITipoIncidenteService
    {
        private readonly HttpClient _httpClient;
        public TipoIncidenteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<TipoIncidente>> GetTiposIncidenteAsync()
        {
            var url = "api/tipoincidente";
            var response = await _httpClient.GetFromJsonAsync<List<TipoIncidente>>(url);
            return response ?? new List<TipoIncidente>();
        }
    }
}
