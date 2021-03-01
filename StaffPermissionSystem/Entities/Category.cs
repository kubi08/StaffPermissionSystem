using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffPermissionSystem.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
