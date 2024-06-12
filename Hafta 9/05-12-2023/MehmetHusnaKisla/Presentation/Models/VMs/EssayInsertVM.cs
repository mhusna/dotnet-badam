using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Presentation.Models.VMs
{
    public class EssayInsertVM
    {
        [Display(Name ="Makale Başlığı")]
        public string EssayName { get; set; }

        [Display(Name = "Makale İçeriği:")]
        public string EssayContent { get; set; }

        public int TopicID { get; set; }

        [Display(Name = "Konu:")]
        public SelectList Topics { get; set; }
    }
}
