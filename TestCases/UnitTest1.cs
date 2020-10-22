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
        [DataRow(100, 30, 20)]
        [DataRow(5, 3, 2)]
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
        public void GivenMaxValueAtSecondPlace_Should_ReturnSecondNumber(int a, int b, int c)
        {
            var expected = b;
            FindMaximum f = new FindMaximum();
            int actual = f.MaximumIntegerNumber(a, b, c);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow(34, 20, 100)]
        [DataRow(651, 354, 5678)]
        public void GivenMaxValueAtThirdPlace_Should_ReturnThirdNumber(int a, int b, int c)
        {
            var expected = c;
            FindMaximum f = new FindMaximum();
            int actual = f.MaximumIntegerNumber(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(134.8F, 20.78F, 100.0F)]
        [DataRow(651.98F, 354.67F, 56.78F)]
        public void GivenMaxFloatValueAtFirstPlace_ShouldReturn_FirstNumber(float a, float b, float c)
        {
            var expected = a;
            FindMaximum f = new FindMaximum();
            float actual = f.MaximumFloatNumber(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(134.8F, 220.78F, 100.0F)]
        [DataRow(51.98F, 354.67F, 56.78F)]
        public void GivenMaxFloatValueAtSecondPlace_ShouldReturn_SecondNumber(float a, float b, float c)
        {
            var expected = b;
            FindMaximum f = new FindMaximum();
            float actual = f.MaximumFloatNumber(a, b, c);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow(134.8F, 220.78F, 1100.0F)]
        [DataRow(51.98F, 354.67F, 536.78F)]
        public void GivenMaxFloatValueAtThirdPlace_ShouldReturn_ThirdNumber(float a, float b, float c)
        {
            var expected = c;
            FindMaximum f = new FindMaximum();
            float actual = f.MaximumFloatNumber(a, b, c);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow("xenon", "apple", "bot")]
        [DataRow("riya", "raghav", "rewati")]
        public void GivenMaxStringValueAtFirstPlace_ShouldReturn_FirstString(string a, string b, string c)
        {
            var expected = a;
            FindMaximum f = new FindMaximum();
            string actual = f.MaximumStringNumber(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("xenon", "zapple", "bot")]
        [DataRow("riya", "vraghav", "rewati")]
        public void GivenMaxStringValueAtSecondPlace_ShouldReturn_SecondString(string a, string b, string c)
        {
            var expected = b;
            FindMaximum f = new FindMaximum();
            string actual = f.MaximumStringNumber(a, b, c);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow("xenon", "apple", "ybot")]
        [DataRow("riya", "raghav", "zrewati")]
        public void GivenMaxStringValueAtThirdPlace_ShouldReturn_ThirdString(string a, string b, string c)
        {
            var expected = c;
            FindMaximum f = new FindMaximum();
            string actual = f.MaximumStringNumber(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("xenon", "apple", "ybot")]
        [DataRow("riya", "raghav", "zrewati")]
        public void GivenMaxStringValueAtThirdPlace_ShouldReturn_ThirdString_UsingGenerics(string a, string b, string c)
        {
            var expected = c;
            FindMaximum f = new FindMaximum();
            string actual = f.Maximum<string>(a, b, c);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow(134.8F, 220.78F, 1100.0F)]
        [DataRow(51.98F, 354.67F, 536.78F)]
        public void GivenMaxFloatValueAtThirdPlace_ShouldReturn_ThirdNumber_UsingGenerics(float a, float b, float c)
        {
            var expected = c;
            FindMaximum f = new FindMaximum();
            float actual = f.Maximum<float>(a, b, c);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [DataRow(34, 20, 100)]
        [DataRow(651, 354, 5678)]
        public void GivenMaxValueAtThirdPlace_Should_ReturnThirdNumber_UsingGenerics(int a, int b, int c)
        {
            var expected = c;
            FindMaximum f = new FindMaximum();
            int actual = f.Maximum<int>(a, b, c);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GivenMaxIntArray_Should_ReturnMaxInt_UsingGenericsClass()
        {
            GenericClass<int> f = new GenericClass<int>(new int[] { 10, 12, 3, 9, 34, 019, 67, 98 });
            int actual = f.MaxMethod();
            int expected = 98;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GivenMaxFloatArray_Should_ReturnMaxNumber_UsingGenericsClass()
        {
            GenericClass<float> f = new GenericClass<float>(new float[] { 18.0F, 12.87F, 3,98F, 49.87F, 34.5F, 019.45F, 67.87F, 98.89F });
            float actual = f.MaxMethod();
            float expected = 98.89F;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GivenMaxStringArray_Should_ReturnMaxString_UsingGenericsClass()
        {
            GenericClass<string> f = new GenericClass<string>(new string[] { "riya", "kishan", "rewant", "seema", "anu", "rewati", "zeal", "rishank" });
            string actual = f.MaxMethod();
            string expected = "zeal";
            Assert.AreEqual(expected, actual);
        }



    }
}


