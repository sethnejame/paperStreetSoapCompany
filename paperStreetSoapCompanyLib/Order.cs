using System;
using System.Collections.Generic;

namespace paperStreetSoapCompanyLib
{
  public class Order
  {
    public Order()
		{

		}
    public Order(int orderId)
		{
			OrderId = orderId;
		}
    public int OrderId { get; private set; }
    public DateTimeOffset? OrderDate { get; set; }

    public bool Validate()
		{
			var isValid = true;

			if (OrderDate == null) isValid = false;

			return isValid;
		}

		public List<Order> Retrieve()
		{
			return new List<Order>();
		}
  }
}