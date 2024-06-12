using System;
using System.Collections.Generic;

namespace EntityFramework_IV.Models
{
    public partial class Kurslar
    {
        public byte? KursId { get; set; }
        public string? KursAdi { get; set; }
        public string? EgitmenAdi { get; set; }
        public DateTime? Baslangictarihi { get; set; }
        public DateTime? Bitistarihi { get; set; }
    }
}
