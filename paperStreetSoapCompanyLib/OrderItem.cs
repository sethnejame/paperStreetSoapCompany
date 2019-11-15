using System;
using System.Collections.Generic;

namespace paperStreetSoapCompanyLib
{
  public class OrderItem
  {
    public OrderItem()
		{

		}
    public OrderItem(int orderItemId)
		{
			OrderItemId = orderItemId;
		}
    public int ProductId { get; set; }
    public int OrderItemId { get; private set; }

    public int Quantity { get; set; }
    public decimal? PurchasePrice { get; set; }

    public bool Validate()
		{
			var isValid = true;

			if (Quantity <= 0) isValid = false;
			if (ProductId <= 0) isValid = false;
			if (PurchasePrice == null) isValid = false;


			return isValid;
		}

		public bool Save()
		{
			return true;
		}

		public OrderItem Retrieve(int orderItemId)
		{
			return new OrderItem();
		}

		public List<OrderItem> Retrieve()
		{
			return new List<OrderItem>();
		}
  }
}