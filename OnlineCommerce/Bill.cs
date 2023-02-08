using System;
namespace OnlineCommerce
{
	public class Bill
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int ProductNumber { get; set; }
		public int CompanyNumber { get; set; }

		public Order Order { get; set; }
		public List<ProductBill> ProductBills { get; set; }
    }
}

