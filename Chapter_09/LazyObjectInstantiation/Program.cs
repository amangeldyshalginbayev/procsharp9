using System;

namespace LazyObjectInstantiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lazy Instantiation *****");

            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Play();
            Console.WriteLine("Now access all tracks:");
            myPlayer.GetAllTracks();

            Console.ReadLine();
        }
    }
}