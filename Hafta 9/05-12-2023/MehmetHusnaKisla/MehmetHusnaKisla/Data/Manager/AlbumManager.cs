using MehmetHusnaKisla.Enums;
using MehmetHusnaKisla.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Data.Manager
{
    public class AlbumManager : BaseManager<Album>
    {
        // Albumleri silmek yerine albumu satıştan kaldırır ve update eder.
        public override void Delete(int id)
        {
            Album album = GetEntityByID(id);
            album.IsOnSale = OnSale.NotForSale;
            Update(album);
        }

        // Tek bir albümü sanatçısı ile birlikte getirir.
        public Album GetAlbumWithArtist(int id)
        {
            return _dbSet.Include("Artist").Where(x => x.AlbumID == id).FirstOrDefault();
        }

        // Albümleri sanatçılarıyla birlikte getirir.
        public List<Album> GetAlbumsWithArtist()
        {
            return _dbSet.Include("Artist").ToList();
        }
    }
}
