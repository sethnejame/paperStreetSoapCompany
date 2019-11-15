using System;

namespace paperStreetSoapCompanyLib
{
  public class CustomerRepository
  {
    public Customer Retrieve(int customerId)
    {
      Customer customer = new Customer(customerId);

      if (customerId == 1)
      {
        customer.Email = "spacecommander@gmail.com";
        customer.LastName = "NeJame";
        customer.FirstName = "Charlie";
      }
      return customer;
    }

    public bool Save(Customer customer)
    {
      return true;
    }
  }
}