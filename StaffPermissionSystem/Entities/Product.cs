using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffPermissionSystem.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Image { set; get; }
        public decimal Price { set; get; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
