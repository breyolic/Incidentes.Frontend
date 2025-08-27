using Incidentes.Web.Entities;

namespace Incidentes.Web.Interfaces
{
    public interface IImpactoService
    {
        Task<List<Impacto>> GetImpactosAsync();
    }
}
