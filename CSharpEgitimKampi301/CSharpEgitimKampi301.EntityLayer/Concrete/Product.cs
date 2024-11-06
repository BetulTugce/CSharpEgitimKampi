using System.Collections.Generic;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        // virtual => Asp.net Core'da kullanılmıyor ancak .Net Frameworkünde var.
        public virtual Category Category { get; set; }

        public List<Order> Orders { get; set; }
    }
}
