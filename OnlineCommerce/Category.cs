using System;
namespace OnlineCommerce
{
	public class Category
	{
		public int Id { get; set; }
		public int Name { get; set; }
		public int ProductNumber { get; set; }
		public int CompanyNumber { get; set; }

        public List<CompanyCategory> CompanyCategories { get; set; }
        public List<Product> Products { get; set; }
    }
	}
}

