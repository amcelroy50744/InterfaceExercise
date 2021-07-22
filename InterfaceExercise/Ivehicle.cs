using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface Ivehicle
    {
        public int wheelSize { get; set; }
        public string oilType { get; set; }
        public int doorCount { get; set; }
        public int truckSize { get; set; }
    }
}
