using System;
using System.Collections.Generic;

namespace ShopObject.Model
{
    public partial class Client
    {
        public Client()
        {
            Cheques = new HashSet<Cheque>();
        }

        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Discount { get; set; }

        public virtual ICollection<Cheque> Cheques { get; set; }
    }
}
