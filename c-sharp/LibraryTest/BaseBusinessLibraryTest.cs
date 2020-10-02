using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTest
{
    [TestClass]
    public class BaseBusinessLibraryTest: BaseTest
    {
         public BaseBusinessLibraryTest(): base()
         {
             
         }

        [TestMethod]
        public void Sum()
        {
           double operatorA = 5;
           double operatorB = 6;
           double expectedValue = 11;
           double? obtainedValue;

           obtainedValue = _baseLogicClass.Sum(operatorA, operatorB);

           Assert.IsNotNull(obtainedValue, "La operación no puede ser un resultado null");
           Assert.AreEqual(expectedValue, obtainedValue, "El resultado no es el esperado");
        }
    }
}