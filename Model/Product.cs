using System;
using System.Collections.Generic;

namespace ShopObject.Model
{
    public partial class Product
    {
        public Product()
        {
            ChequeProducts = new HashSet<ChequeProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal PriceForOne { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<ChequeProduct> ChequeProducts { get; set; }
    }
}
