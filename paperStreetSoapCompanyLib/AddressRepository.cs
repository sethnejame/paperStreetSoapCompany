using System;
using System.Collections.Generic;

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

    public IEnumerable<Address> RetrieveByCustomerId(int customerId)
    {
      var addressList = new List<Address>();
      Address address = new Address(1)
      {
        AddressType = 1,
        StreetLine1 = "1600 Taft Avenue",
        StreetLine2 = "Apt. 403",
        City = "Los Angeles",
        State = "California",
        Country = "US",
        PostalCode = "90028"
      };
      addressList.Add(address);

      address = new Address(1)
      {
        AddressType = 1,
        StreetLine1 = "903 Figueroa Terrace",
        StreetLine2 = "Apt. 604",
        City = "Los Angeles",
        State = "California",
        Country = "US",
        PostalCode = "91208"
      };
      addressList.Add(address);

      return addressList;
    }
    public bool Save(Address address)
    {
      return true;
    }
  }


}