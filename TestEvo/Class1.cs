using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEvo
{
    public class Class1
    {

        public double factorial(int num)
        {
            int fac = 1;
            while (num != 0)
            {
                fac = fac * num;
                num--;
            }
            return fac;
        }
        public bool multiplo(int num, int mul)
        {
            if (num % mul == 0)
                return true;
            return false;
        }
        public bool comparar(int a, int b)
        {
            if (a < b)
                return true;
            return false;
        }
    }
}
