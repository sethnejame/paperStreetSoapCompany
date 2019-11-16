using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
        Email = "spacecommander@gmail.com",
        FirstName = "Charlie",
        LastName = "NeJame"
      };

      var actual = customerRepo.Retrieve(1);

      Assert.AreEqual(expected.CustomerId, actual.CustomerId);
      Assert.AreEqual(expected.Email, actual.Email);
      Assert.AreEqual(expected.FirstName, actual.FirstName);
      Assert.AreEqual(expected.LastName, actual.LastName);
    }
    [TestMethod]
    public void RetrieveExistingWithAddress()
    {
      var customerRepo = new CustomerRepository();
      var expected = new Customer(1)
      {
        Email = "spacecommander@gmail.com",
        FirstName = "Charlie",
        LastName = "NeJame",
        AddressList = new List<Address>()
        {
          new Address()
          {
            AddressType = 1,
            StreetLine1 = "1600 Taft Avenue",
            StreetLine2 = "Apt. 403",
            City = "Los Angeles",
            State = "California",
            Country = "US",
            PostalCode = "90028"
          },
          new Address()
          {
            AddressType = 1,
            StreetLine1 = "903 Figueroa Terrace",
            StreetLine2 = "Apt. 604",
            City = "Los Angeles",
            State = "California",
            Country = "US",
            PostalCode = "91208"
          }
        }
      };

      var actual = customerRepo.Retrieve(1);

      Assert.AreEqual(expected.CustomerId, actual.CustomerId);
      Assert.AreEqual(expected.Email, actual.Email);
      Assert.AreEqual(expected.FirstName, actual.FirstName);
      Assert.AreEqual(expected.LastName, actual.LastName);

      for (int i = 0; i < expected.AddressList.Count; i++)
      {
        Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
        Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
        Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
        Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
        Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
        Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
        Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
      }
    }
  }
}