using MehmetHusnaKisla.Enums;
using MehmetHusnaKisla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Utilities
{
    public static class AlbumUtility
    {
        // Bir veya birden fazla albüm yazdırır.
        public static void DisplayAlbum(string title, params Album[]? list)
        {
            Console.Clear();
            Console.WriteLine($"## {title} ##");
            var anonymousList = list.Select(x => new { x.AlbumID, x.AlbumName, x.PublishTime, x.Price, x.Discount, x.IsOnSale, x.Artist.ArtistName }).ToList();
            foreach (var album in list)
                Console.WriteLine($"ID: {album.AlbumID} - Album Adı: {album.AlbumName} - Çıkış Tarihi: {album.PublishTime} - Fiyat: {album.Price} - İndirim: {album.Discount} - Satışta Mı?: {album.IsOnSale} - Sanatçı: {album.Artist.ArtistName}");
            
        }

        // Kullanıcıdan albüm bilgilerini alır.
        public static Album GetInformation(Album album)
        {
            Console.Write("Albüm adı: ");
            album.AlbumName = Console.ReadLine();
            
            bool result;
            do
            {
                Console.Write("Çıkış Tarihi: ");
                string tarihString = Console.ReadLine();
                result = DateTime.TryParse(tarihString, out DateTime tarihDT);
                if (result)
                    album.PublishTime = tarihDT;
                else
                {
                    Console.WriteLine("Geçersiz tarih formatı.");
                    Console.WriteLine("\nDevam etmek için 'Enter' tuşlayınız..");
                    Console.ReadLine();
                    Console.Clear();
                    Console.Write("Albüm adı: " + album.AlbumName);
                }

            } while (!result);

            Console.Write("Fiyat: ");
            album.Price = double.Parse(Console.ReadLine());

            Console.Write("İndirim: ");
            album.Discount = double.Parse(Console.ReadLine());

            do
            {
                Console.Write("Satışta mı ? Evet[e] - Hayır[h]: ");
                string satistaMi = Console.ReadLine();

                result = true;
                if (satistaMi.ToLower() == "e")
                    album.IsOnSale = OnSale.ForSale;
                else if (satistaMi.ToLower() == "h")
                    album.IsOnSale = OnSale.NotForSale;
                else
                {
                    result = false;
                    Console.WriteLine("Yanlış seçim yaptınız !");
                    Console.WriteLine("Devam Etmek İçin 'Enter' Tuşlayınız !");
                    Console.ReadLine();
                }

            } while (!result);

            album.InsertTime = DateTime.Now;

            Console.Write("Sanatçı ID: ");
            album.ArtistID = int.Parse(Console.ReadLine());

            return album;
        }
    }
}
