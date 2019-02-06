using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOpsToday.Models;

namespace DevOpsToday.MSTesting.Tests
{
  [TestClass]
  public class ErrorViewModelsTests
  {
    [TestMethod]
    public void Test_ShowRequestIdMethod()
    {
      var sut = new ErrorViewModel() {RequestId = "Oak"};

      Assert.IsTrue(sut.ShowRequestId);
    }
  }
}