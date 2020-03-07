using Microsoft.VisualStudio.TestTools.UnitTesting;
using webapiCalculadora.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace utCalculadora
{
    [TestClass]
    public class UnitTestCalculadora
    {
        

        [TestMethod]
        public void TestAddGet1()
        { //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 7;

            //Act = Ejecucion
            int result = calc.Add(numa, numb);

            //Assert = Verificaion
            Assert.AreEqual(numres, result);
        }

        [TestMethod]
        public void TestAddGet2()
        { //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = -1;
            int numb = -1;
            int numres = -2;

            //Act = Ejecucion
            int result = calc.Add(numa, numb);

            //Assert = Verificaion
            Assert.AreEqual(numres, result);
        }

        [TestMethod]
        public void TestAddGet3()
        { //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = 6;
            int numb = 4;
            int numc = 3;
            int numres = 10;

            //Act = Ejecucion
            int result = calc.Add(numa, numb, numc);

            //Assert = Verificaion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestAddGet4()
        { //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = -6;
            int numb = -4;
            int numc = -3;
            int numres = -10;

            //Act = Ejecucion
            int result = calc.Add(numa, numb, numc);

            //Assert = Verificaion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet1()
        { //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = 6;
            int numb = 4;
            int numres = 24;

            //Act = Ejecucion
            int result = calc.Multiply(numa, numb);

            //Assert = Verificaion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet2()
        { //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = -6;
            int numb = -4;
            int numres = 24;

            //Act = Ejecucion
            int result = calc.Multiply(numa, numb);

            //Assert = Verificaion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet3()
        { //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = 5;
            int numb = 2;
            int numc = 2;
            int numres = 10;

            //Act = Ejecucion
            int result = calc.Multiply(numa, numb, numc);

            //Assert = Verificaion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet4()
        { //Arrange = Preparacion
            CalculatorController calc = new CalculatorController();
            int numa = -5;
            int numb = -2;
            int numc = 2;
            int numres = 10;

            //Act = Ejecucion
            int result = calc.Multiply(numa, numb, numc);

            //Assert = Verificaion
            Assert.AreEqual(numres, result);
        }


    }
}
