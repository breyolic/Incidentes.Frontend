using Incidentes.Web.StateContainers;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Incidentes.Web.Layout
{
    public partial class MainLayout
    {
        [Inject]
        public IncidenteStateContainer IncidenteStateContainer { get; set; } = default!;
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        bool _drawerOpen = true;

        void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }

        protected override void OnAfterRender(bool firstRender)
        {
            var url = NavigationManager.Uri;

            if (!(url.Contains("registro-incidente"))
                && IncidenteStateContainer.EjecutaFlujo)
            {
                IncidenteStateContainer.Limpiar();
            }
        }
    }
}