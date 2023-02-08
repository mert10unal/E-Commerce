using System;
namespace OnlineCommerce
{
	public class ProductBill
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int BillId { get; set; }

		public Product Product { get; set; }
		public Bill Bill { get; set; }
    }
}

