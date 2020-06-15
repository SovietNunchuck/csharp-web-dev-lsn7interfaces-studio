using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
        public int Capacity { get; }
        public List<string> Contents { get; set; }
        public int[] SpinRate { get; }
        public string DiscType { get; }

        public BaseDisc(string name, int capacity, List<string> contents, string discType)
        {
            Name = name;
            Capacity = capacity;
            Contents = contents;
            DiscType = discType;
        }

        public void SpinDisc()
        {
            int[] spinSpeed = new int[2];
            if (DiscType == "DVD")
            {
                spinSpeed[0] = 570;
                spinSpeed[1] = 1600;
            }
            else
            {
                spinSpeed[0] = 200;
                spinSpeed[1] = 500;
            }
            Console.WriteLine($"A {DiscType} spins at a rate of {spinSpeed[0]} - {spinSpeed[1]} rpm.");
        }

        public void ReportData()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
