using System;

namespace paperStreetSoapCompanyLib
{
  public class AddressRepository
  {
    public Address Retrieve(int addressId)
    {
      Address address = new Address(addressId);

      if (addressId == 1)
      {
        address.AddressType = 1;
        address.StreetLine1 = "1600 Taft Avenue";
        address.StreetLine2 = "Apt. 403";
        address.City = "Los Angeles";
        address.State = "California";
        address.Country = "US";
        address.PostalCode = "90028";
      }

      return address;
    }
  }
}