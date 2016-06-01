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
           
            
                double modulo = 0;
                double resul = a - b;
            if (resul >= 0)
            {
                modulo = Math.Sqrt(resul);
                return modulo;
            }
            else

                throw new ArgumentException( "La diferencia es negatica");
        }
       public List<int> numeroDivisores(int num)
        {
            List<int> div = new List<int>();
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    div.Add(i);
            }
            return div;
        }
    
    }
    public class Persona
    {
        private string nombre;
        private char sexo;
        public Persona(string nombre,char sexo)
        {
            this.nombre = nombre;
            this.sexo = sexo;
        }
        public Persona()
        {
            nombre = null;
            sexo = '0';
        }
        public string getnombre()
        {
            return nombre;
        }
        public void personaCreada()
        {
            if (sexo == '0' || nombre == null)
            {
                throw new ArgumentException("No agrego el nombre y tampoco el sexo");
            }

        }
    }
}
