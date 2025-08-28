using Incidentes.Web.Entities;

namespace Incidentes.Web.Interfaces
{
    public interface IPrioridadService
    {
        Task<List<Prioridad>> GetPrioridadesAsync();
    }
}
