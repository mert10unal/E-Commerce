using System;
namespace OnlineCommerce
{
	public class Order
	{
		public int Id { get; set; }
		public int orderCode { get; set; }
		public string Address { get; set; }
		public DateTime DeliveryTime { get; set; }
		public string CustomerName { get; set; }
		public string CustomerSurname { get; set; }

		public List<ProductOrder> ProductOrders { get; set; }
		public Bill Bill { get; set; }

    }
}

