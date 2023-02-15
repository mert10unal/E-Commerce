using System;
namespace OnlineCommerce
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CategoryId { get; set; }

		public List<ProductOrder> ProductOrders { get; set; }
		public Category Category { get; set; }
		public List<CompanyProduct> CompanyProduct { get; set; }
        public List<ProductBill> ProductBills { get; set; }
    }
}

