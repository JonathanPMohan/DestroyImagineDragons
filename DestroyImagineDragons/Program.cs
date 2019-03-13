using System;
using System.Collections.Generic;
using System.Linq;

namespace DestroyImagineDragons
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();

            List<Song> allSongs = new List<Song>()

            {
                new Song("Wu-Tang Clan", "Protect Ya Neck"),
                new Song("Imagine Dragons", "Crappy Song 1"),
                new Song("Prince", "Purple Rain"),
                new Song("Nas", "If I Ruled The World"),
                new Song("Method Man", "Bring The Pain"),
                new Song("Imagine Dragons", "Crappy Song 2"),
                new Song("Rage Against The Machine", "Guerilla Radio"),
                new Song("Dire Staits", "Money For Nothing"),
                new Song("Imagine Dragons","Hipster Nickelback"),
                new Song("Mobb Deep", "Shook Ones"),
                new Song("My Morning Jacket", "Golden"),
                new Song("Neil Young", "Old Man"),
                new Song("Outkast", "So Fresh & So Clean"),
                new Song("Imagine Dragons", "Wow! We Suck"),
                new Song("N.W.A.", "Straight Outta' Compton")
            };

            goodSongs = allSongs.Where(song => song.Artist != "Imagine Dragons").ToList();

            foreach (Song song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
          }
            Console.ReadKey();
        }
    }
}
