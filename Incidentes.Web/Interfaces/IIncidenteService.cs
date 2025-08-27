using Incidentes.Web.Entities;

namespace Incidentes.Web.Interfaces
{
    public interface IIncidenteService
    {
        Task<Incidente> GetIncidente(int id);
        Task<bool> CrearIncidenteAsync(Incidente incidente);
    }
}
