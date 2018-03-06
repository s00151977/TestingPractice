using NUnit.Framework;
using NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestingPractice2
{
    [TestFixture]
    static public class Class1
    {
          static Premium2 p;

          [SetUp]
          static public void init()
          {
              p = new Premium2();
          }

          [Test]
          static public void Test1()
          {
              double expectedResult = 5;

              double actualResult = p.CalcPremium(25, "female");

              Assert.AreEqual(expectedResult, actualResult);
          }

          [Test]
          static public void Test2()
          {
              double expectedResult = 3.5;

              double actualResult = p.CalcPremium(32, "female");

              Assert.AreEqual(expectedResult, actualResult);
          }

          [Test] 
          static public void Test3()
          {
              double expectedResult = 1.75;

              double actualResult = p.CalcPremium(55, "female");

              Assert.AreEqual(expectedResult, actualResult);
          }

          [Test]
          static public void Test4()
          {
              double expectedResult = 0;

              double actualResult = p.CalcPremium(15, "female");

              Assert.AreEqual(expectedResult, actualResult);
          }

          [Test]
          static public void Test5()
          {
              double expectedResult = 6;

              double actualResult = p.CalcPremium(25, "male");

              Assert.AreEqual(expectedResult, actualResult);
          }

          [Test]
          static public void Test6()
          {
              double expectedResult = 5;

              double actualResult = p.CalcPremium(37, "male");

              Assert.AreEqual(expectedResult, actualResult);
          }

          [Test]
          static public void Test7()
          {
              double expectedResult = 2.5;

              double actualResult = p.CalcPremium(55, "male");

              Assert.AreEqual(expectedResult, actualResult);
          }

          [Test]
          static public void Test8()
          {
              double expectedResult = 0;

              double actualResult = p.CalcPremium(15, "male");

              Assert.AreEqual(expectedResult, actualResult);
          }
     
    }
}