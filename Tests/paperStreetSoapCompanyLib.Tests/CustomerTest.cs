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
  }
}
