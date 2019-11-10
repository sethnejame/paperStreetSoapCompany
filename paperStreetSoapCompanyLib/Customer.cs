using System;

namespace paperStreetSoapCompanyLib
{
  public class Customer
  {
		public string FirstName { get; set; }
    private string _lastName;
		public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				_lastName = value;
			}
		}

  }
}
