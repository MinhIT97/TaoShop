using System;
using System.Collections.Generic;

namespace TaoShop.Models.DB
{
    public partial class OderDetail
    {
        public int Id { get; set; }
        public int OderId { get; set; }
        public int ProductId { get; set; }
        public int? Price { get; set; }
        public int? Quantity { get; set; }

        public Oders Oder { get; set; }
        public Laptop Product { get; set; }
    }
}
