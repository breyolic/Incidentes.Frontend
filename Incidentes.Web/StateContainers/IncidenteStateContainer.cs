namespace Incidentes.Web.StateContainers
{
    public class IncidenteStateContainer : StateContainerBase
    {
        private bool _ejecutaFlujo;
        public bool EjecutaFlujo
        {
            get => _ejecutaFlujo;
            set
            {
                if (_ejecutaFlujo != value)
                {
                    _ejecutaFlujo = value;
                    NotifyStateChanged();
                }
            }
        }

        public int? IdIncidente;

        public void Limpiar()
        {
            IdIncidente = null;
            _ejecutaFlujo = false;
            NotifyStateChanged();
        }
    }
}
