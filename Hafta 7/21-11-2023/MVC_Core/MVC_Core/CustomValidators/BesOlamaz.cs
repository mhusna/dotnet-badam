using System.ComponentModel.DataAnnotations;

namespace MVC_Core.CustomValidators
{
    public class BesOlamaz:ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(value != null)
                return !value.ToString().Contains("5");

            // Buradan geçse bile Required validator devreye girecek.
            return true;
        }
    }
}
