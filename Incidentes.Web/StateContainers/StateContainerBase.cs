namespace Incidentes.Web.StateContainers
{
    public abstract class StateContainerBase
    {
        public event Action? OnChange;
        protected void NotifyStateChanged() => OnChange?.Invoke();
    }
}
