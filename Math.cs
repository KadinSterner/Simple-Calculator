using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Math : ICalculator // Using this class to perform calculations
    {
        public void Add()
        {
            Data.result += Convert.ToDouble(Data.input.Dequeue());
        }

        public void Divide()
        {
            Data.result /= Convert.ToDouble(Data.input.Dequeue());
        }

        public void Multiply()
        {
            Data.result *= Convert.ToDouble(Data.input.Dequeue());
        }

        public void Subtract()
        {
            Data.result -= Convert.ToDouble(Data.input.Dequeue());
        }
    }
}
