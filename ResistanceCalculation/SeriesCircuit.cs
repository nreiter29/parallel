using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistanceCalculation
{
    class SeriesCircuit : ICalculation
    {
        public double ResistorOne { get; set; }
        public double ResistorTwo { get; set; }

        public double GetTotalResistance()
        {
            return  ResistorOne + ResistorTwo;
        }
    }
}
