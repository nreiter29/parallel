using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistanceCalculation
{
    interface ICalculation
    {
        double ResistorOne { get; set; }
        double ResistorTwo { get; set; }
        double GetTotalResistance();
    }
}
