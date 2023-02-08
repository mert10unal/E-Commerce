using System;
namespace OnlineCommerce
{
	public class CompanyCategory
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public int CompanyId { get; set; }
		public Category Category { get; set; }
		public Company Company { get; set; }


    }
}

