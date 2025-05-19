using System.ComponentModel.DataAnnotations;

namespace Lab14.Clases
{
    public class Animal
    {
        [Required(ErrorMessage = "El nombre del animal.")]
        public string? nombre_propio {  get; set; }
        [Required(ErrorMessage = "Se requiere la especie del animal.")]
        public string? especie {  get; set; }
        [Required(ErrorMessage = "Se requiere el tipo de alimentacion.")]
        public string? tipo_alimentacion { get; set; }
        [Required(ErrorMessage = "Se requiere el dato de la esperanza de vida.")]
        public string? esperanza_vida { get; set; }

    }
}
