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
      FindAndReplace findReplace = new FindAndReplace("Great Big Text", "Big", "Large");

      //Act
      string result = findReplace.GetText();

      //Assert
      Assert.AreEqual("Great Big Text", result);
    }

    [TestMethod]
    public void GetFind_ConstructorTest()
    {
      //Arrange
      FindAndReplace findReplace = new FindAndReplace("Great Big Text", "Big", "Large");

      //Act
      string result = findReplace.GetFind();

      //Assert
      Assert.AreEqual("Big", result);
    }

    [TestMethod]
    public void GetReplace_ConstructorTest()
    {
      //Arrange
      FindAndReplace findReplace = new FindAndReplace("Great Big Text", "Big", "Large");

      //Act
      string result = findReplace.GetReplace();

      //Assert
      Assert.AreEqual("Large", result);
    }

    [TestMethod]
    public void GetIndex_ReturnIndex()
    {
      //Arrange
      FindAndReplace findReplace = new FindAndReplace("Great Big Text", "Big", "Large");

      //Act
      int result = findReplace.GetIndex(0);

      //Assert
      Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void ReplaceAll_ReplaceAllOccurrencesOfFind()
    {
      //Arrange
      FindAndReplace findReplace = new FindAndReplace("BIg Great biG Text big", "Big", "Large");

      //Act
      string result = findReplace.ReplaceAll();

      //Assert
      Assert.AreEqual("Large Great Large Text Large", result);
    }
  }
}
