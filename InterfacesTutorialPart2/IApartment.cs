using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTutorialPart2
{
    interface IApartment
    {
        int Id { get; set; }
        int Floor { get; set; }
        double SizeInSquareMeters { get; set; }

    }
}
