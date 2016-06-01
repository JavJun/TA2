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
            string resultado = prueba.multiplo(45, 9);
            Assert.AreNotEqual("No Multiplo", resultado);
        }
        
        //BOOLEAN
        [TestMethod()]
        public void compararTest2()
        {
            Class1 prueba = new Class1();

            Assert.IsTrue(prueba.comparar(5, 20));
        }
        //excepciones
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void diferencia()
        {
            Class1 prueba = new Class1();
            prueba.diferenciaRaizCuadrada(3, 7);

        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void personaCreada()
        {
            Persona prueba = new Persona();
            prueba.personaCreada();

        }

        //objeto
        [TestMethod()]
        public void persona()
        {
            Persona per = new Persona("juan",'m');
            Persona per2 = new Persona("Jaime", 'm');
            Assert.AreNotSame(per2, per);
        }
        //nulo
        [TestMethod()]
        public void persona1()
        {
            Persona per = new Persona();
            
            Assert.IsNull(per.getnombre());
        }


    }
}