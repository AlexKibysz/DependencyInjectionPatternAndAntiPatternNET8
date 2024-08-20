using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIPattern.Models
{
    public class Coffee
    {
        [Key]
        [Range(1, 5, ErrorMessage = "Debe ser un valor entre 1 y 5")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres")]

        public string Name { get; set; } = "CoffeUnknow";


        [StringLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres")]
        public string Description { get; set; } = "-";

        [Required(ErrorMessage = "La intensidad es obligatoria")]
        [Range(0, 10, ErrorMessage = "La intensidad debe estar entre 1 y 10")]
        public int Intensity { get; set; } = 0;

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.00, 9999.99, ErrorMessage = "El precio debe estar entre 0.01 y 9999.99")]
        public decimal Price { get; set; } = decimal.Zero;

        [StringLength(200, ErrorMessage = "El origen no puede exceder los 200 caracteres")]
        public string Origin { get; set; } = string.Empty;


        [Required(ErrorMessage = "La fecha de tostado es obligatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfRoast { get; set; } = DateTime.MinValue;

        [Url(ErrorMessage = "Debe ser una URL válida")]
        public string Picture { get; set; } = string.Empty;
    }

 
}
