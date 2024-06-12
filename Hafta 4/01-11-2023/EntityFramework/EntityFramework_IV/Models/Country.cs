using System;
using System.Collections.Generic;

namespace EntityFramework_IV.Models
{
    public partial class Country
    {
        public Country()
        {
            Locations = new HashSet<Location>();
        }

        public string CountryId { get; set; } = null!;
        public string? CountryName { get; set; }
        public decimal? RegionId { get; set; }

        public virtual Region? Region { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
