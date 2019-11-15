using System;
using System.Collections.Generic;

namespace paperStreetSoapCompanyLib
{
  public class Product
  {
		public Product()
		{

		}
		public Product(int productId)
		{
			ProductId = productId;
		}
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }

    public decimal? CurrentPrice { get; set; }
    public int ProductId { get; private set; }

    public bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(ProductDescription)) isValid = false;
			if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
			if (CurrentPrice == null) isValid = false;

			return isValid;
		}

		public bool Save()
		{
			return true;
		}

		public Product Retrieve(string ProductId)
		{
			return new Product();
		}

		public List<Product> Retrieve()
		{
			return new List<Product>();
		}
  }
}