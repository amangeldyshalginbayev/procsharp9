using System;

namespace LazyObjectInstantiation
{
    public class AllTracks
    {
        private Song[] _allSongs = new Song[10_000];

        public AllTracks(string name)
        {
            // Assume we fill the _allSongs with 10_000 objects here
            Console.WriteLine("Filling up 10_000 songs here!!!");
        }
    }
}