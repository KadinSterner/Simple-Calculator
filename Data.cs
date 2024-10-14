using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Data
    {
        public static Queue input = new Queue(); // The whole application is based on queueing inputs to be operated on
        public static double result; // Globally storing the result so that the app can always go back to it
        public static int opSwitch; // Tells the calculator which operations to do, recieved in input via + | - | * | / inputs
    }
}
