using MathPgcd;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPgcd
{
  [TestClass]
  public class UnitTestPgcd
  {
    [TestMethod]
    public void TestMethod_1()
    {
      const int source1 = 9;
      const int source2 = 6;
      const int expected = 3;
      int result = Program.Pgcd(source1, source2);
      Assert.AreEqual(result, expected);
    }
  }
}