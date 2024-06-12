using MehmetHusnaKisla.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public IsDeleted IsDeleted { get; set; }

        public ICollection<Album>? Albums { get; set; }
    }
}
