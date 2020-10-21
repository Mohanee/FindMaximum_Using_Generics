using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Maximum_Using_Generics;
using System.Security.Cryptography.X509Certificates;

namespace TestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(100, 30,20)]
        [DataRow(5,3,2)]
        public void GivenMaxValueAtFirstNumber_ShouldReturn_FirstNumberAsMaximum(int a, int b, int c)
        {
            var expected = a;
            FindMaximum f = new FindMaximum();
            int actual = f.MaximumIntegerNumber(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(104, 123, 18)]
        [DataRow(651, 5693, 724)]
        public void GivenMaxValueAtSecondPlace_WhenChecked_Should_ReturnSecondNumber(int a, int b, int c)
        {
            var expected = b;
            FindMaximum f = new FindMaximum();
            int actual = f.MaximumIntegerNumber(a,b,c);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow(34, 20, 100)]
        [DataRow(651, 354, 5678)]
        public void GivenMaxValueAtThirdPlace_WhenChecked_Should_ReturnThirdNumber(int a, int b, int c)
        {
            var expected = c;
            FindMaximum f = new FindMaximum();
            int actual = f.MaximumIntegerNumber(a,b,c);
            Assert.AreEqual(expected, actual);
        }


    }
    
}
