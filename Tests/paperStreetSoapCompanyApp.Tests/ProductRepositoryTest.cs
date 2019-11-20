using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace paperStreetSoapCompanyApp.Tests
{
  [TestClass]
  public class ProductRepositoryTest
  {
    [TestMethod]
    public void RetrieveValid()
    {
      var productRepo = new ProductRepository();
      var expected = new Product(7)
      {
        ProductName = "Fancy Soap",
        ProductDescription = "Made from the finest ingredients available",
        CurrentPrice = 99
      };

      var actual = productRepo.Retrieve(7);

      Assert.AreEqual(expected.ProductName, actual.ProductName);
      Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
      Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
    }
     [TestMethod]
    public void SaveTestValid()
    {
      var productRepo = new ProductRepository();
      var updatedProduct = new Product(7)
      {
        ProductName = "Fancy Soap",
        ProductDescription = "Made from the finest ingredients available",
        CurrentPrice = 99,
        HasChanges = true
      };

      var actual = productRepo.Save(updatedProduct);

      Assert.AreEqual(true, actual);
    }
  }
}