using System.ComponentModel.DataAnnotations;

namespace Lab14.Clases
{
    public class Aves : Animal
    {
        [Required(ErrorMessage = "Se requiere el dato ¿Puede volar?")]
        public string? vuela {  get; set; }
        [Required(ErrorMessage = "El tiempo de incubacion es obligatorio.")]
        public string? tiempo_incubacion { get; set; }
    }
}
