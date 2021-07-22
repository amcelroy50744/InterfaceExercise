using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV: ICompany, Ivehicle
    {
        public string sport { get; set; }
        public bool legRoom { get; set; }
        public string countryOfOrgin { get; set; }
        public string logo { get; set; }
        public int wheelSize { get; set; }
        public string oilType { get; set; }
        public int doorCount { get; set; }
        public int truckSize { get; set; }
    }
}
