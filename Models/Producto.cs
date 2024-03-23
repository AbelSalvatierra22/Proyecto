using System.ComponentModel.DataAnnotations;

namespace TechStore.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción del producto es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio del producto es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0")]
        public decimal Precio { get; set; }

        public decimal CalcularIGV()
        {
            return Precio * 0.18m; 
        }
    }
}

