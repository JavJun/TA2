using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestEvo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEvo.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void factorialTest()
        {
            Class1 prueba = new Class1();
            double resultado = prueba.factorial(5);

            //EXPECTATIVA, Valor de tu funcion
            Assert.AreEqual(120, resultado);
        }

        [TestMethod()]
        public void multiploTest()
        {
            Class1 prueba = new Class1();
            bool resultado = prueba.multiplo(25, 2);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod()]
        public void compararTest()
        {
            Class1 prueba = new Class1();
            bool resultado = prueba.comparar(25, 2);
            Assert.AreEqual(false, resultado);
        }
    }
}