using System;

namespace paperStreetSoapCompanyLib
{
  public class OrderRepository
  {
    public Order Retrieve(int orderId)
    {
      Order order = new Order(orderId);

      if (orderId == 1)
      {
        order.OrderDate = new DateTimeOffset();
      }
      return order;
    }
    public bool Save(Order order)
    {
      return true;
    }
  }
}