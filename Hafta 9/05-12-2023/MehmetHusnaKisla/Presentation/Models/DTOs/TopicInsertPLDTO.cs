using System.ComponentModel.DataAnnotations;

namespace Presentation.Models.DTOs
{
    public class TopicInsertPLDTO
    {
        [Display(Name = "Konu Başlığı: ")]
        public string TopicName { get; set; }
    }
}
