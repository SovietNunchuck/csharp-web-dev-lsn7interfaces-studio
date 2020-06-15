using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARING AND INITIALIZING OBJECTS TO WORK WITH
            CD testCD = new CD("Foo Fighters", "The Colour and the Shape", 700, new List<string> { "Monkey Wrench", "Everlong", "My Hero" }, "CD");
            DVD testDVD = new DVD("Austin Powers: Goldmember", 4700, new List<string> { "Movie", "Unrated Version", "Special Features" }, "DVD");
            CD blankCD = new CD(700);

            //SPINDISC METHOD SIMPLY TELLS YOU HOW FAST EACH TYPE OF DISC SPINS
            testCD.SpinDisc();
            testDVD.SpinDisc();

            Console.WriteLine("\n*****\n");

            //REPORTDATA METHOD CAN BE CALLED DIRECTLY, BUT IT'S ALSO CALLED BY THE READDATA METHOD BELOW BECAUSE THAT MAKES MORE SENSE
            testCD.ReportData();
            testDVD.ReportData();
            blankCD.ReportData();

            Console.WriteLine("*****\n");

            //WRITEDATA METHOD REQUIRES USER INPUT
            testCD.WriteData();
            testDVD.WriteData();
            blankCD.WriteData();
            blankCD.ReportData();

            Console.WriteLine("\n*****");

            //THE LASER READS THE DATA ON THE DISC AND REPORTS WHAT IT FINDS
            testCD.ReadData();
            testDVD.ReadData();
        }
    }
}
