using System.ComponentModel.DataAnnotations;

namespace Incidentes.Web.Entities
{
    public class Incidente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(200, ErrorMessage = "La descripción debe tener entre 10 y 200 caracteres", MinimumLength = 10)]
        public string Descripcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe seleccionar un impacto")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un impacto válido")]
        public int IdImpacto { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una prioridad")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una prioridad válida")]
        public int IdPrioridad { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un tipo de incidente")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un tipo de incidente válido")]
        public int IdTipoIncidente { get; set; }

        [Required(ErrorMessage = "El nombre completo es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre completo debe tener máximo 100 caracteres")]
        public string NombreCompleto { get; set; } = string.Empty;

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Phone(ErrorMessage = "El teléfono no es válido")]
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido")]
        public string Email { get; set; } = string.Empty;
    }
}
