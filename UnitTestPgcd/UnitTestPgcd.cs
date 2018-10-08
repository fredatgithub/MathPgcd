using MathPgcd;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPgcd
{
  [TestClass]
  public class UnitTestPgcd
  {
    [TestMethod]
    public void TestMethod_9_and_6()
    {
      const int source1 = 9;
      const int source2 = 6;
      const int expected = 3;
      int result = Program.Pgcd(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_6_and_9()
    {
      const int source1 = 6;
      const int source2 = 9;
      const int expected = 3;
      int result = Program.Pgcd(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_15_and_5()
    {
      const int source1 = 15;
      const int source2 = 5;
      const int expected = 5;
      int result = Program.Pgcd(source1, source2);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_1071_and_1029()
    {
      // PGCD(1 071 ; 1 029) = 21
      const int source1 = 1071;
      const int source2 = 1029;
      const int expected = 21;
      int result = Program.Pgcd(source1, source2);
      Assert.AreEqual(result, expected);
    }
  }
}