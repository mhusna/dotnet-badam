using MehmetHusnaKisla.Enums;
using MehmetHusnaKisla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Utilities
{
    public static class ReportUtility
    {
        public static void DisplayReportMenu()
        {
            Console.Clear();
            Console.WriteLine("1- Albüm Listesi");
            Console.WriteLine("2- Satışı Durmuş Albümler");
            Console.WriteLine("3- Satışı Devam Eden Albümler");
            Console.WriteLine("4- Sisteme En Son Eklenen 10 Albüm");
            Console.WriteLine("5- İndirimdeki Albümler (Z - A)");
        }

        // Genel yazdırma fonksiyonu, başlığı, filtreyi ve ham listeyi parametre alarak sorgulama yapar.
        public static void DisplayAllAlbumWithFilter(string title, Func<Album, bool>? filter = null, params Album[]? list)
        {
            Console.Clear();
            Console.WriteLine($"## {title} ##");

            if (filter == null)
            {
                var anonymousList = list.Select(x => new { x.AlbumName, x.Artist.ArtistName, x.IsOnSale }).ToList();
                foreach (var album in list)
                    Console.WriteLine($"Album Adı: {album.AlbumName} - Sanatçı: {album.Artist.ArtistName} - Satışta Mı?: {album.IsOnSale}");

            }

            else
            {
                var anonymousList = list.Where(filter).Select(x => new { x.AlbumName, x.Artist.ArtistName }).ToList();

                foreach (var album in list)
                    Console.WriteLine($"Album Adı: {album.AlbumName} - Sanatçı: {album.Artist.ArtistName} - Satışta Mı?: {album.IsOnSale}");
            }

        }

        // Son eklenen albümleri yazdırır, başlığı, kaç tane yazdıracağını ve ham albüm listesini alır ve sorgulama yapar.
        public static void DisplayLastAlbums(string title, int takeCount, params Album[]? list)
        {
            Console.Clear();
            Console.WriteLine($"## {title} ##");

            var anonymousList = list.Select(x => new { x.AlbumName, x.Artist.ArtistName, x.InsertTime }).OrderByDescending(x => x.InsertTime).Take(takeCount).ToList();

            foreach (var album in anonymousList)
                Console.WriteLine($"Album Adı: {album.AlbumName} - Sanatçı: {album.ArtistName} - Ekleme Zamanı: {album.InsertTime}");
        }

        // İndirimdeki albümleri yazdırır, başlığı, ham albüm listesini alır ve sorgulama yapar.
        public static void DiscountedAlbums(string title, params Album[]? list)
        {

            Console.Clear();
            Console.WriteLine($"## {title} ##");

            var anonymousList = list.Where(x => x.Discount > 0).Select(x => new { x.AlbumName, x.Artist.ArtistName, x.Discount}).OrderByDescending(x => x.Discount).ToList();

            foreach (var album in anonymousList)
                Console.WriteLine($"Album Adı: {album.AlbumName} - Sanatçı: {album.ArtistName} - İndirim Oranı: {album.Discount}");

        }

        // Satışta olmayan albümleri yazdırır, başlığı, ham albüm listesini alır ve sorgulama yapar.
        public static void DisplayAllNotForSale(string title, params Album[]? list)
        {

            Console.Clear();
            Console.WriteLine($"## {title} ##");

            var filteredList = list.Where(x => x.IsOnSale == OnSale.NotForSale).ToList();

            var anonymousList = filteredList.Select(x => new { x.AlbumName, x.Artist.ArtistName, x.IsOnSale}).ToList();

            foreach (var album in anonymousList)
                Console.WriteLine($"Album Adı: {album.AlbumName} - Sanatçı: {album.ArtistName} - Satışta Mı ?: {album.IsOnSale}");

        }

        // Satıştaki albümleri yazdırır, başlığı, ham albüm listesini alır ve sorgulama yapar.
        public static void DisplayAllForSale(string title, params Album[]? list)
        {

            Console.Clear();
            Console.WriteLine($"## {title} ##");

            var filteredList = list.Where(x => x.IsOnSale == OnSale.ForSale).ToList();

            var anonymousList = filteredList.Select(x => new { x.AlbumName, x.Artist.ArtistName, x.IsOnSale }).ToList();

            foreach (var album in anonymousList)
                Console.WriteLine($"Album Adı: {album.AlbumName} - Sanatçı: {album.ArtistName} - Satışta Mı ?: {album.IsOnSale}");

        }
    }
}
