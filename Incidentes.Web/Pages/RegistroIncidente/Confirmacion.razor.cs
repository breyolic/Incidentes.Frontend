using Incidentes.Web.Entities;
using Incidentes.Web.Interfaces;
using Incidentes.Web.StateContainers;
using Microsoft.AspNetCore.Components;

namespace Incidentes.Web.Pages.RegistroIncidente
{
    public partial class Confirmacion : IDisposable
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;
        [Inject]
        public IncidenteStateContainer IncidenteStateContainer { get; set; } = default!;
        [Inject]
        public IIncidenteService IncidenteService { get; set; } = default!;

        private Incidente _incidente = new();

        protected override async Task OnInitializedAsync()
        {
            IncidenteStateContainer.OnChange += StateHasChanged;

            if (!IncidenteStateContainer.EjecutaFlujo)
            {
                NavigationManager.NavigateTo("/");
                return;
            }
            var incidente = await IncidenteService.GetIncidente(IncidenteStateContainer.IdIncidente!.Value);
            _incidente = incidente;
            await InvokeAsync(StateHasChanged);
        }

        private void OnRegistrarNuevo()
        {
            IncidenteStateContainer.Limpiar();
            NavigationManager.NavigateTo("/registro-incidente");
        }

        public void Dispose()
        {
            IncidenteStateContainer.OnChange -= StateHasChanged;
        }
    }
}