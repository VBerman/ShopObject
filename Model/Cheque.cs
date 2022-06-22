using System;
using System.Collections.Generic;

namespace ShopObject.Model
{
    public partial class Cheque
    {
        public Cheque()
        {
            ChequeProducts = new HashSet<ChequeProduct>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public decimal Total { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<ChequeProduct> ChequeProducts { get; set; }
    }
}
