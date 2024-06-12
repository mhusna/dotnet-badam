using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using MVC_Core.CustomValidators;
namespace MVC_Core.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage ="Boş geçemezsiniz.."),
         StringLength(20, MinimumLength = 3, ErrorMessage = "En az  3 en fazla 20 karakter girebilirsiniz.")]
        [BesOlamaz(ErrorMessage = "Beş ihtiva edemez..")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş geçemezsiniz..")]
        [Range(1, 1000, ErrorMessage = "1-1000 arası değer giriniz..")]
        public double Price { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        [NotMapped]
        public IFormFile? Image { get; set; }

        public int? BrandID { get; set; }
        public Brand? Brand { get; set; }

        public int? CategoryID { get; set; }
        public Category? Category { get; set; }
    }
}
