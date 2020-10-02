using BaseBusinessLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTest
{
    [TestClass]
    public class BaseTest
    {
        protected readonly BaseLogicClass _baseLogicClass;

        public BaseTest()
        {
            _baseLogicClass = new BaseLogicClass();
        }
   
        [TestInitialize]
        public void Setup()
        {
             // Runs before each test. (Optional)
        }
    
        [TestCleanup]
        public void TearDown()
        { 
            // Runs after each test. (Optional)
        }
    }
}
