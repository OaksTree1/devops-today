using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOpsToday.Models;

namespace DevOpsToday.MSTesting.Tests
{
  public class ErrorViewModelsTests
  {
    public void Test_ShowRequestIdMethod()
    {
      var sut = new ErrorViewModelsTests() {RequestId = "Oak"};

      Assert.IsTrue(sut.ShowRequestId);
    }
  }
}