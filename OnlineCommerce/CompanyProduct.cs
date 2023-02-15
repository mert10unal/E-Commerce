using System;
namespace OnlineCommerce
{
	public class CompanyProduct
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int CompanyId { get; set; }
		public double Price { get; set; }

        public Product Product { get; set; }
        public Company Company { get; set; }
    }
}

