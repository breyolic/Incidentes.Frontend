using Incidentes.Web.Entities;
using Incidentes.Web.Interfaces;
using Incidentes.Web.StateContainers;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Incidentes.Web.Pages.RegistroIncidente
{
    public partial class RegistroIncidente : IDisposable
    {
        [Inject] ISnackbar Snackbar { get; set; } = default!;
        [Inject] IIncidenteService IncidenteService { get; set; } = default!;
        [Inject] NavigationManager NavigationManager { get; set; } = default!;
        [Inject]
        public IncidenteStateContainer IncidenteStateContainer { get; set; } = default!;
        private Incidente _model = new();

        protected override void OnInitialized()
        {
            IncidenteStateContainer.OnChange += StateHasChanged;
        }

        private async Task RegistrarIncidente()
        {
            var res = await IncidenteService.CrearIncidenteAsync(_model);
            if (res.EsValido)
            {
                IncidenteStateContainer.IdIncidente = res.IdIncidente;
                IncidenteStateContainer.EjecutaFlujo = true;
                NavigationManager.NavigateTo("registro-incidente/confirmacion");
            }
            else
            {
                Snackbar.Add($"Error: {res.PropiedadError} - {res.MensajeError}, ", Severity.Error);
            }
        }

        public void Dispose()
        {
            IncidenteStateContainer.OnChange -= StateHasChanged;
        }
    }
}