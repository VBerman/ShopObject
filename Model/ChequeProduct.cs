using System;
using System.Collections.Generic;

namespace ShopObject.Model
{
    public partial class ChequeProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ChequeId { get; set; }
        public int Quantity { get; set; }

        public virtual Cheque Cheque { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
