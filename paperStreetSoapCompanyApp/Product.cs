using System;
using System.Collections.Generic;
using Common;

namespace paperStreetSoapCompanyApp
{
  public class Product : EntityBase, ILoggable
  {
		public Product()
		{

		}
		public Product(int productId)
		{
			ProductId = productId;
		}
		private string _productName;
    public string ProductName
		{
			get
			{
				return StringHandler.InsertSpaces(_productName);
			}
			set
			{
				_productName = value;
			}
		}
    public string ProductDescription { get; set; }

    public decimal? CurrentPrice { get; set; }
    public int ProductId { get; private set; }

		public string Log() =>
			$"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";


		public override string ToString() => ProductName;

    public override bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(ProductDescription)) isValid = false;
			if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
			if (CurrentPrice == null) isValid = false;

			return isValid;
		}
  }
}