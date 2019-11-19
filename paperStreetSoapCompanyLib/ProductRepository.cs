using System;

namespace paperStreetSoapCompanyLib
{
  public class ProductRepository
  {
    public Product Retrieve(int productId)
    {
      Product product = new Product(productId);
      {
        if (productId == 7)
        {
          product.ProductName = "Fancy Soap";
          product.ProductDescription = "Made from the finest ingredients available";
          product.CurrentPrice = 99;
        }
        Object myObject = new Object();
        Console.WriteLine($"Object: {myObject.ToString()}");
        Console.WriteLine($"Product: {product.ToString()}");
        return product;
      }
    }
    public bool Save(Product product)
    {
      return true;
    }
  }
}