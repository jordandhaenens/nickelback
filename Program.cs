using System;
using System.Collections.Generic;
using System.Linq;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
           List<(string Song, string Artist)> goodSongs = new List<(string Song, string Artist)>();

           HashSet<(string, string)> allSongs = new HashSet<(string, string)>();

           allSongs.Add(("Better Days", "Pipe Smokers"));
           allSongs.Add(("Dog Days", "Set of Pipes"));
           allSongs.Add(("Something Just Like This", "Chainsmokers & Coldplay"));
           allSongs.Add(("Alone", "Marshmellow"));
           allSongs.Add(("Down", "Marian Hill"));
           allSongs.Add(("Photograph", "Nickelback"));
           allSongs.Add(("Rockstar", "Nickelback"));

          goodSongs = allSongs.Where(song => song.Item2 != "Nickelback").ToList();
        
           foreach ((string Song, string Artist) song in goodSongs) {
               Console.WriteLine($"{song.Song} by {song.Artist}");
           }
        }
    }
}
