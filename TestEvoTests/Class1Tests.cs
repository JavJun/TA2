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
            string resultado = prueba.multiplo(25, 2);
            Assert.AreEqual("No Multiplo", resultado);
        }
        [TestMethod()]
        public void multiploTest2()
        {
            Class1 prueba = new Class1();
            string resultado = prueba.multiplo(45, 9);
            Assert.AreEqual("Multiplo", resultado);
        }

        [TestMethod()]
        public void compararTest()
        {
            Class1 prueba = new Class1();
            bool resultado = prueba.comparar(25, 2);
            Assert.AreEqual(false, resultado);
        }
        //diferentes
        [TestMethod()]
        public void compararTest1()
        {
            Class1 prueba = new Class1();
            bool resultado = prueba.comparar(25, 2);
            Assert.AreNotEqual(true, resultado);
        }
        [TestMethod()]
        public void multiploTest3()
        {
            Class1 prueba = new Class1();
            string resultado = prueba.multiplo(40, 9);
            Assert.AreNotEqual("No Multiplo", resultado);
        }

        [TestMethod()]
        public void factorialTest1()
        {
            Class1 prueba = new Class1();
            double resultado = prueba.factorial(3);

            Assert.AreNotEqual(7, resultado);
        }

        [TestMethod()]
        public void raizCuadradaTest()
        {
            Class1 prueba = new Class1();
            double resultado = prueba.diferenciaRaizCuadrada(9,5);

            Assert.AreNotEqual(3, resultado);
        }
        //BOOLEAN
        [TestMethod()]
        public void compararTest2()
        {
            Class1 prueba = new Class1();

            Assert.IsTrue(prueba.comparar(5, 20));
        }

        [TestMethod()]
        [ExpectedException(typeof(System.ArgumentException))]
        public void raizCuadradaTest1()
        {
            Class1 prueba = new Class1();
            double resultado = 0;
              resultado =  prueba.diferenciaRaizCuadrada(5, 6);


        }

        
    }
}