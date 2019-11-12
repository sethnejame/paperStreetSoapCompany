using System;
using System.Collections.Generic;

namespace paperStreetSoapCompanyLib
{
  public class Product
  {
		public Product()
		{
			
		}
    public string Name { get; set; }
    public string Description { get; set; }

    public int CurrentPrice { get; set; }

    public bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(Description)) isValid = false;
			if (string.IsNullOrWhiteSpace(Name)) isValid = false;
			if (CurrentPrice < 0) isValid = false;

			return isValid;
		}

		public bool Save()
		{
			return true;
		}

		public Product Retrieve(string ProductName)
		{
			return new Product();
		}

		public List<Product> Retrieve()
		{
			return new List<Product>();
		}
  }