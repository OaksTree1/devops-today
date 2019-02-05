using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevOpsToday.Controllers;

namespace DevOpsToday.MSTesting.Tests
{
  [TestClass]
  public class HomeControllerTests
  {
     [TestMethod]
    public void IndexTestAction ()
    {
      var sut = new HomeController();

        Assert.IsNotNull(sut.Index());
     }
      [TestMethod]
     public void PrivacyTestAction ()
    {
      var sut = new HomeController();

        Assert.IsNotNull(sut.Privacy());
     }

     public void ErrorTestAction ()
    {
      var sut = new HomeController();

        Assert.IsNotNull(sut.Error());
     }


  }
}
