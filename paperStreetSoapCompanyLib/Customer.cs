using System;

namespace paperStreetSoapCompanyLib
{
  public class Customer
  {
		public int CustomerId { get; private set; }
		public string Email { get; set; }
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
		public string FullName
		{
			get
			{
				return LastName + "," + FirstName;
			}
		}

  }
}
