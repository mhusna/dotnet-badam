using MehmetHusnaKisla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Utilities
{
    public static class ArtistUtility
    {
        public static void DisplayArtist(string title, params Artist[]? list)
        {
            Console.Clear();
            Console.WriteLine($"## {title} ##");
            foreach (Artist artist in list)
                Console.WriteLine($"ID: {artist.ArtistID} - Adı: {artist.ArtistName}");
        }

        public static Artist GetInformation(Artist artist)
        {
            Console.Write("Sanatçı Adı: ");
            artist.ArtistName = Console.ReadLine();

            return artist;
        }
    }
}
