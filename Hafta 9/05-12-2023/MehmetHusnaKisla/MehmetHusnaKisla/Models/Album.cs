using MehmetHusnaKisla.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public DateTime PublishTime { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public OnSale IsOnSale { get; set; }
        public DateTime InsertTime { get; set; }

        public int? ArtistID { get; set; }
        public Artist? Artist { get; set; }
    }
}
