using System;
using System.Collections.Generic;
using System.Linq;

namespace paperStreetSoapCompanyApp
{
  public class CustomerRepository
  {
    public CustomerRepository()
    {
      addressRepository = new AddressRepository();
    }
    private AddressRepository addressRepository { get; set; }
    public Customer Retrieve(int customerId)
    {
      Customer customer = new Customer(customerId);

      if (customerId == 1)
      {
        customer.Email = "spacecommander@gmail.com";
        customer.LastName = "NeJame";
        customer.FirstName = "Charlie";
        customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
      }
      return customer;
    }

    public bool Save(Customer customer)
    {
      return true;
    }
  }
}