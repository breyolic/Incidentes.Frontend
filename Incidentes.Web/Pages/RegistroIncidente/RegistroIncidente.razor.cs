using Incidentes.Web.Entities;
using Incidentes.Web.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Incidentes.Web.Pages.RegistroIncidente
{
    public partial class RegistroIncidente
    {
        [Inject] ISnackbar Snackbar { get; set; } = default!;
        [Inject] IIncidenteService IncidenteService { get; set; } = default!;
        [Inject] NavigationManager NavigationManager { get; set; } = default!;
        private Incidente _model = new();

        private async Task RegistrarIncidente()
        {
            var res = await IncidenteService.CrearIncidenteAsync(_model);
            if (res.EsValido)
            {
                NavigationManager.NavigateTo("registro-incidente/confirmacion");
            }
            else
            {
                Snackbar.Add($"Error: {res.PropiedadError} - {res.MensajeError}, ", Severity.Error);
            }
        }
    }
}