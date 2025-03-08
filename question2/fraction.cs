using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    internal class fraction
    {
        public int Dividend;
        public int Divisor;

        public fraction(int dividend, int divisor)
        {
            Dividend = dividend;
            Divisor = divisor;
        }

        public void Display()
        {
            double decimalvlaue = (double)Dividend / Divisor;
            Console.WriteLine(Dividend + "/" + Divisor+"="+decimalvlaue);

        }
    }


}
