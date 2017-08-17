using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOnlyCalculator
{
    public class Calculator
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int add()
        {
            return First+Second;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
