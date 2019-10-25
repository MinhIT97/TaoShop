using System;
using System.Collections.Generic;

namespace TaoShop.Models.DB
{
    public partial class Deliverer
    {
        public Deliverer()
        {
            Oders = new HashSet<Oders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public ICollection<Oders> Oders { get; set; }
    }
}
