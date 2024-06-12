using MehmetHusnaKisla.Enums;
using MehmetHusnaKisla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Data.Manager
{
    public class ArtistManager : BaseManager<Artist>
    {
        public override void Delete(int id)
        {
            Artist artist = GetEntityByID(id);
            artist.IsDeleted = IsDeleted.Passive;
            Update(artist);
        }
    }
}
