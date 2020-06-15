using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public DVD(string name, int capacity, List<string> contents, string discType) : base(name, capacity, contents, discType) { }


        public void WriteData()
        {
            Console.WriteLine("DVD has been formatted so that it cannot be overwritten.");
        }

        public override string ToString()
        {
            string formattedContents = "";
            int x = 1;
            foreach (string feature in Contents)
            {
                formattedContents += $"{x}. {feature}\n";
                x++;
            }
            string formattedString = $"Disc Type: {DiscType}\n" +
                $"Film Name: {Name}\n" +
                $"Capacity: {Capacity} MB\n" +
                $"Contents:\n{formattedContents}";
            return formattedString;
        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

    }
}
