using Incidentes.Web.Entities;

namespace Incidentes.Web.Interfaces
{
    public interface ITipoIncidenteService
    {
        Task<List<TipoIncidente>> GetTiposIncidenteAsync();
    }
}
