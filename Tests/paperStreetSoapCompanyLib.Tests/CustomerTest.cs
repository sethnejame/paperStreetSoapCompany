using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace paperStreetSoapCompanyLib.Tests
{
  [TestClass]
  public class CustomerTest
  {
    [TestMethod]
    public void FullNameTestValid()
    {
      Customer customer = new Customer
      {
        FirstName = "Charlie",
        LastName = "NeJame"
      };
      string expected = "NeJame, Charlie";

      string actual = customer.FullName;

      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void FullNameFirstNameEmpty()
    {
      Customer customer = new Customer
      {
        LastName = "NeJame"
      };
      string expected = "NeJame";

      string actual = customer.FullName;

      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void FullNameLastNameEmpty()
    {
      Customer customer = new Customer
      {
        FirstName = "Charlie"
      };
      string expected = "Charlie";

      string actual = customer.FullName;

      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void StaticTest()
    {
      var c1 = new Customer();
      c1.FirstName = "Charlie";
      Customer.InstanceCount += 1;

      var c2 = new Customer();
      c2.FirstName = "Milo";
      Customer.InstanceCount += 1;

      var c3 = new Customer();
      c3.FirstName = "Fat Bob";
      Customer.InstanceCount += 1;

      Assert.AreEqual(3, Customer.InstanceCount);
    }

    [TestMethod]
    public void ValidateValid()
    {
      var customer = new Customer
      {
        LastName = "NeJame",
        Email = "spacecommander@gmail.com"
      };

      var expected = true;

      var actual = customer.Validate();

      Assert.AreEqual(expected, actual);
    }
  }
}
