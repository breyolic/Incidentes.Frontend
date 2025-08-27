namespace Incidentes.Web.Entities
{
    public class Incidente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public int IdImpacto { get; set; }
        public int IdPrioridad { get; set; }
        public int IdTipoIncidente { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
