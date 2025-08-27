using Incidentes.Web.DbResult;
using Microsoft.AspNetCore.Components;

namespace Incidentes.Web.Pages.RegistroIncidente
{
    public partial class Confirmacion
    {
        [Inject]
        NavigationManager NavigationManager { get; set; } = default!;

        private IncidenteResult _result = new();

        private void OnRegistrarNuevo()
        {
            NavigationManager.NavigateTo("/registro-incidente");
        }
    }
}