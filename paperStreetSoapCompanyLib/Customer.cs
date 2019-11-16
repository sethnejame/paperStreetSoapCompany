using System;
using System.Collections.Generic;

namespace paperStreetSoapCompanyLib
{
  public class Customer
  {
		public Customer(): this(0)
		{

		}
		public Customer(int customerId)
		{
			CustomerId = customerId;
			AddressList = new List<Address>();
		}

		public List<Address> AddressList { get; set; }
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
				string fullName = LastName;
				if (!string.IsNullOrWhiteSpace(FirstName))
					{
						if (!string.IsNullOrWhiteSpace(fullName))
						{
							fullName += ", ";
						}
						fullName += FirstName;
					}
				return fullName;
			}
		}

		public bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
			if (string.IsNullOrWhiteSpace(Email)) isValid = false;

			return isValid;
		}

		public static int InstanceCount { get; set; }

  }
}
