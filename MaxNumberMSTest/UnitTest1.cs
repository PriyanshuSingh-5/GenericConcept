using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GenericConcept;

namespace MaxNumberMSTest
{
    [TestClass]
    public class UnitTest1
    {
        //UC1
        [TestMethod]
        [DataRow(1, 2, 3, 3)]
        [DataRow(1, 4, 2, 4)]
        [DataRow(5, 2, 1, 5)]
        public void MaximumIntegerNumber_ReturnMaximumNumber(int a, int b, int c, int max)
        {
            int result = FindMaxNum.FindMaxInteger(a, b, c);
            Assert.AreEqual(result, max);
        }

        //UC2
        [TestMethod]
        [DataRow(1.1f, 2.2f, 3.3f, 3.3f)]
        [DataRow(1.1f, 4.4f, 2.2f, 4.4f)]
        [DataRow(5.5f, 2.2f, 1.1f, 5.5f)]
        public void MaximumFloatNumber__ReturnMaximumNumber(float a, float b, float c, float max)
        {
            float result = FindMaxNum.MaximumFloatNumber(a, b, c);
            Assert.AreEqual(result, max);
        }

        //UC3
        [TestMethod]
        [DataRow("1", "2", "3", "3")]
        [DataRow("1", "4", "2", "4")]
        [DataRow("5", "2", "1", "5")]
        public void MaximumStringNumber_PassThreeNumbers_ReturnMaximum(string a, string b, string c, string max)
        {
            string result = FindMaxNum.MaximumString(a, b, c);
            Assert.AreEqual(result, max);
        }

        [TestMethod]
        public void MaximumNumberGenericInteger_PassThreeNumbers_ReturnMaximumNumber()
        {
            int[] intArray = { 112, 344, 432, 555, 678 };
            Generic<int> generic = new Generic<int>(intArray);
            int result = generic.MaxMethod();
            Assert.AreEqual(result, 678);
        }

        //UC4 more than 3 parameters
        [TestMethod]
        public void MaximumNumberGenericFloat_PassThreeNumbers_ReturnMaximumNumber()
        {
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            Generic<double> genericDouble = new Generic<double>(doubleArray);
            double result = genericDouble.MaxMethod();
            Assert.AreEqual(result, 55.5);
        }

        [TestMethod]
        public void MaximumNumberGenericString_PassThreeNumbers_ReturnMaximumNumber()
        {
            string[] stringArray = { "111", "222", "333", "55", "999" };
            Generic<string> genericString = new Generic<string>(stringArray);
            string result = genericString.MaxMethod();
            Assert.AreEqual(result, "999");
        }
    }
}