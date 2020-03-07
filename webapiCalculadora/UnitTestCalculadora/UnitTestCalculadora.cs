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
    }
}
