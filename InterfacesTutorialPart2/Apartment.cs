using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTutorialPart2
{
    public class Apartment : IApartment, IDimensionMetric, IDimensionImperial
    {
        public int Id { get; set; }
        public int Floor { get; set; }
        public double SizeInSquareMeters { get; set; }

        double IDimensionMetric.GetSize()
        {
           return SizeInSquareMeters;
        }

        double IDimensionImperial.GetSize()
        {
            return Math.Round(SizeInSquareMeters * 10.746, 2);
        }
    }
}
