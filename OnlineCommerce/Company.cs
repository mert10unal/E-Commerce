using System;
namespace OnlineCommerce
{
	public class Company
	{
		public int Id { get; set; }
		public string CompanyName { get; set; }
		public int CompanyProductId { get; set; }

		public CompanyProduct Companyproduct { get; set; }
    }
}

