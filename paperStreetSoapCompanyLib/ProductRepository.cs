using System;

namespace paperStreetSoapCompanyLib
{
  public class ProductRepository
  {
    public Product Retrieve(int productId)
    {
      Product product = new Product(productId);
      {
        if (productId == 1)
        {
          product.ProductName = "Fancy Soap";
          product.ProductDescription = "Made from the finest ingredients available.";
          product.CurrentPrice = 99;
        }
        return product;
      }
    }
    public bool Save(Product product)
    {
      return true;
    }
  }
}