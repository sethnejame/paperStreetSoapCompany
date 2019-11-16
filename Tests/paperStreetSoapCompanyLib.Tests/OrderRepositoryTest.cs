using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace paperStreetSoapCompanyLib.Tests
{
  [TestClass]
  public class OrderRepositoryTest
  {
    [TestMethod]
    public void RetrieveValid()
    {
      var orderRepo = new OrderRepository();
      var expected = new Order(21)
      {
        OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
      };

      var actual = orderRepo.Retrieve(21);

      Assert.AreEqual(expected.OrderDate, actual.OrderDate);
    }
  }
}