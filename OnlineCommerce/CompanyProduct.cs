using System;
namespace OnlineCommerce
{
	public class CompanyProduct
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int CompanyId { get; set; }

        public List<Product> Products { get; set; }
        public List<Company> Companies { get; set; }
    }
}

