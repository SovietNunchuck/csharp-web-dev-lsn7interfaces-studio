using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD testCD = new CD("Foo Fighters", "The Colour and the Shape", 700, new List<string> { "Monkey Wrench", "Everlong", "My Hero" }, "CD");
            DVD testDVD = new DVD("Austin Powers: Goldmember", 4700, new List<string> { "Movie", "Unrated Version", "Special Features" }, "DVD");


            // TODO: Call each CD and DVD method to verify that they work as expected.
            testCD.SpinDisc();
            testDVD.SpinDisc();

            Console.WriteLine("\n*****\n");

            testCD.ReportData();
            testDVD.ReportData();

            Console.WriteLine("*****\n");



        }
    }
}
