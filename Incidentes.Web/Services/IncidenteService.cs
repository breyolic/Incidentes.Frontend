using Incidentes.Web.DbResult;
using Incidentes.Web.Entities;
using Incidentes.Web.Interfaces;
using System.Net.Http.Json;

namespace Incidentes.Web.Services
{
    public class IncidenteService : IIncidenteService
    {
        private readonly HttpClient _httpClient;
        public IncidenteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IncidenteResult> CrearIncidenteAsync(Incidente incidente)
        {
            var url = "api/incidente";
            var response = await _httpClient.PostAsJsonAsync(url, incidente);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<IncidenteResult>();
                return result;
            }
            else
            {
                return new IncidenteResult { PropiedadError = "Desconocido", MensajeError = $"Error en el servidor" };
            }
        }

        public async Task<Incidente> GetIncidente(int id)
        {
            var url = $"api/incidente/{id}";
            var response = await _httpClient.GetFromJsonAsync<Incidente>(url);
            return response ?? new Incidente();
        }
    }
}
