using System;
namespace OnlineCommerce
{
	public class Company
	{
		public int Id { get; set; }
		public string CompanyName { get; set; }
		public int CompanyId { get; set; }

        public List<CompanyCategory> CompanyCategories { get; set; }
		public CompanyProduct Companyproduct { get; set; }
    }
}

