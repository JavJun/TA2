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
        public string multiplo(int a, int b)
        {
            if (a % b == 0)
                return "Multiplo";
            return "No Multiplo";
        }
        public bool comparar(int a, int b)
        {
            if (a < b)
                return true;
            return false;
        }
        public double diferenciaRaizCuadrada(double a,double b)
        {
            try
            {
                double modulo = 0;
                double resul = a - b;

                modulo = Math.Sqrt(resul);

                return modulo;
            }
            catch(Exception ex)
            {
                System.ArgumentException argEx = new ArgumentException("La diferencia de los numeros es menor que 0");
                throw argEx;
            }
        }
    }
}
