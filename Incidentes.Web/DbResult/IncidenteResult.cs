namespace Incidentes.Web.DbResult
{
    public class IncidenteResult : DbResult
    {
        public int IdIncidente { get; set; }
        public string FechaRegistro { get; set; } = string.Empty;
        public string HoraRegistro { get; set; } = string.Empty;
    }
}
