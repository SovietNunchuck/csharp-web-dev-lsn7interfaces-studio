using System;
using System.Collections.Generic;
using System.Transactions;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        public string Artist { get; set; }
        private bool _writeable = false;

        public CD(string artist, string name, int capacity, List<string> contents, string discType) : base(name, capacity, contents, discType)
        {
            Artist = artist;
        }

        public CD(int capacity) : this("None", "None", capacity, new List<string> { }, "CD") { _writeable = true; }

        public void WriteData()
        {
            if (_writeable)
            {
                int trackCount = 0;
                Console.WriteLine("Initiating CD burn...\nCD Artist: ");
                Artist = Console.ReadLine();
                Console.WriteLine("Album Title: ");
                Name = Console.ReadLine();
                Console.WriteLine("Number of tracks: ");
                try
                {
                    trackCount = int.Parse(Console.ReadLine());
                }
                catch { }
                

                for (int i=0; i < trackCount; i++)
                {
                    Console.WriteLine($"Enter name for track {i+1}:");
                    Contents.Add(Console.ReadLine());
                }

                Console.WriteLine("\nCD was burned successfully.\n");
            }
            else
            {
                Console.WriteLine("CD is not burnable.");
            }
        }

        public override string ToString()
        {
            string formattedContents = "";
            int x = 1;
            foreach (string track in Contents)
            {
                formattedContents += $"{x}. {track}\n";
                x++;
            }
            string formattedString = $"Disc Type: {DiscType}\n" +
                $"Artist: {Artist}\n" +
                $"Album Name: {Name}\n" +
                $"Capacity: {Capacity} MB\n" +
                $"Contents:\n{formattedContents}";
            return formattedString;
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        
    }
}
