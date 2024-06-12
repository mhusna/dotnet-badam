using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Data.Manager
{
    public class ManagerBLL
    {
        public AdminManager AdminManager { get; set; }
        public ArtistManager ArtistManager { get; set; }
        public AlbumManager AlbumManager { get; set; }

        public ManagerBLL()
        {
            AdminManager = new AdminManager();
            ArtistManager = new ArtistManager();
            AlbumManager = new AlbumManager();
        }
    }
}
