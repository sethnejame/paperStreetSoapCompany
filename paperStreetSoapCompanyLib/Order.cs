using System;
using System.Collections.Generic;

namespace paperStreetSoapCompanyLib
{
  public class Order
  {
    public Order() : this(0)
    {

    }
    public Order(int orderId)
    {
      OrderId = orderId;
      OrderItems = new List<OrderItem>();
    }
    public int OrderId { get; private set; }
    public DateTimeOffset? OrderDate { get; set; }
    public int CustomerId { get; set; }
    public int ShippingAddressId { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    public int CustomerType { get; set; }

    public bool Validate()
    {
      var isValid = true;

      if (OrderDate == null) isValid = false;

      return isValid;
    }
  }
}