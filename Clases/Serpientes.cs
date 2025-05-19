using System.ComponentModel.DataAnnotations;

namespace Lab14.Clases
{
    public class Serpientes : Animal
    {
        [Required(ErrorMessage = "El dato es necesario ¿Es venenoso?.")]
        public string? veneno {  get; set; }
        [Required(ErrorMessage = "El tamaño (el largo) de la serpiente es obligatorio.")]
        public string? largo { get; set; }
    }
}
