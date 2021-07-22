using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : Ivehicle, ICompany
    {
        public int bedSize { get; set; }
        public bool offRoadEnabled { get; set; }
        public string countryOfOrgin { get; set; }
        public string logo { get; set; }
        public int wheelSize { get; set; }
        public string oilType { get; set; }
        public int doorCount { get; set; }
        public int truckSize { get; set; }
      
    }
}
