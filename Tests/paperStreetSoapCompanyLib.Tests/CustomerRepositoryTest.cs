using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace paperStreetSoapCompanyLib.Tests
{
  [TestClass]
  public class CustomerRepositoryTest
  {
    [TestMethod]
    public void RetrieveValid()
    {
      var customerRepo = new CustomerRepository();
      var expected = new Customer(1)
      {
        customerId = 1,
        Email = "spacecommander@gmail.com",
        FirstName = "Charlie",
        LastName = "NeJame"
      };

      var actual = customerRepo.Retrieve(1);

      Assert.AreEqual(expected, actual);
    }
  }
}