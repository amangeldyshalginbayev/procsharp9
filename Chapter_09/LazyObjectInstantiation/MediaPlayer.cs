using System;

namespace LazyObjectInstantiation
{
    public class MediaPlayer
    {
        // private AllTracks _allSongs = new AllTracks();
        //
        // public AllTracks GetAllTracks()
        // {
        //     return _allSongs;
        // }

        //private Lazy<AllTracks> _allSongs = new Lazy<AllTracks>();

        private Lazy<AllTracks> _allSongs = new Lazy<AllTracks>(() =>
        {
            Console.WriteLine("Creating all tracks object");
            return new AllTracks("some name");
        });
        public AllTracks GetAllTracks()
        {
            return _allSongs.Value;
        }

        

        public void Play()
        {
            //play song
        }

        public void Pause()
        {
            //pause song
        }

        public void Stop()
        {
            //stop song
        }
    }
}