using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindReplace.Models;

namespace FindReplace.Models.Tests
{
  [TestClass]
  public class FindReplaceTest
  {
    [TestMethod]
    public void GetText_ConstructorTest()
    {
      //Arrange
      FindReplace findReplace = new FindReplace("Great Big Text", "Big", "Large");

      //Act
      string result = findReplace.GetText();

      //Assert
      Assert.AreEqual("Great Big Text", result);
    }

    [TestMethod]
    public void GetFind_ConstructorTest()
    {
      //Arrange
      FindReplace findReplace = new FindReplace("Great Big Text", "Big", "Large");

      //Act
      string result = findReplace.GetFind();

      //Assert
      Assert.AreEqual("Big", result);
    }

    [TestMethod]
    public void GetReplace_ConstructorTest()
    {
      //Arrange
      FindReplace findReplace = new FindReplace("Great Big Text", "Big", "Large");

      //Act
      string result = findReplace.GetReplace();

      //Assert
      Assert.AreEqual("Large", result);
    }

    [TestMethod]
    public void GetIndex_ReturnIndex()
    {
      //Arrange
      FindReplace findReplace = new FindReplace("Great Big Text", "Big", "Large");

      //Act
      int result = findReplace.GetIndex();

      //Assert
      Assert.AreEqual(6, result);
    }
  }
}
