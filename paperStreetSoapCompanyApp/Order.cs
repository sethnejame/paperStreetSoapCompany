using System;
using System.Collections.Generic;
using Common;

namespace paperStreetSoapCompanyApp
{
  public class Order : EntityBase, ILoggable
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

    public string Log() =>
			$"{OrderId}: Date: {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";


    public override string ToString() =>
          $"{OrderDate.Value.Date} ({OrderId})";

    public override bool Validate()
    {
      var isValid = true;

      if (OrderDate == null) isValid = false;

      return isValid;
    }
  }
}