using System;
using System.Collections.Generic;

namespace TaoShop.Models.DB
{
    public partial class Oders
    {
        public Oders()
        {
            OderDetail = new HashSet<OderDetail>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public byte? Status { get; set; }
        public int DelivererId { get; set; }
        public int? TotalPrice { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Deliverer Deliverer { get; set; }
        public AspNetUsers User { get; set; }
        public ICollection<OderDetail> OderDetail { get; set; }
    }
}
