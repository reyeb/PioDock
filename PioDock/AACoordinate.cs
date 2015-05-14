using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PioDock
{
    class AACoordinate
    {
        public int ResiNumber { get; set; }
        public string atomName { get; set; }
        public string chainName { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
}
