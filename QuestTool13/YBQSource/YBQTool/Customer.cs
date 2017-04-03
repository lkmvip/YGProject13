using System;
using System.ComponentModel;
namespace RxjhTool
{
	[DefaultProperty("Name")]
	public class Customer
	{
		private string _address;
		private int _age;
		private DateTime _dateOfBirth;
		private string _email;
		private bool _frequentBuyer;
		private string _name;
		private string _SSN;
		[Category("ID Settings"), Description("Address of the customer")]
		public string Address
		{
			get
			{
				return this._address;
			}
			set
			{
				this._address = value;
			}
		}
		[Category("ID Settings"), Description("Age of the customer")]
		public int Age
		{
			get
			{
				return this._age;
			}
			set
			{
				this._age = value;
			}
		}
		[Category("ID Settings"), Description("Date of Birth of the Customer (optional)")]
		public DateTime DateOfBirth
		{
			get
			{
				return this._dateOfBirth;
			}
			set
			{
				this._dateOfBirth = value;
			}
		}
		[Category("Marketting Settings"), Description("Most current e-mail of the customer")]
		public string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				this._email = value;
			}
		}
		[Category("Marketting Settings"), Description("If the customer has bought more than 10 times, this is set to true")]
		public bool FrequentBuyer
		{
			get
			{
				return this._frequentBuyer;
			}
			set
			{
				this._frequentBuyer = value;
			}
		}
		[Category("ID Settings"), Description("Name of the customer")]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		[Category("ID Settings"), Description("Social Security Number of the customer")]
		public string SSN
		{
			get
			{
				return this._SSN;
			}
			set
			{
				this._SSN = value;
			}
		}
	}
}
