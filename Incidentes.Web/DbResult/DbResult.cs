namespace Incidentes.Web.DbResult
{
    public abstract class DbResult
    {
        public bool EsValido { get; set; }
        public string PropiedadError { get; set; } = string.Empty;
        public string MensajeError { get; set; } = string.Empty;
    }
}
