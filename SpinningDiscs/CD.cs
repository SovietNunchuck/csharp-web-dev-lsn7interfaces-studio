using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        public string Artist { get; }

        public CD(string artist, string name, int capacity, List<string> contents, string discType) : base(name, capacity, contents, discType)
        {
            Artist = artist;
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
                $"Contents:\n{formattedContents}\n";
            return formattedString;
        }
        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
    }
}
