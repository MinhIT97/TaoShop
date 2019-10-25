using System;
using System.Collections.Generic;

namespace TaoShop.Models.DB
{
    public partial class Laptop
    {
        public Laptop()
        {
            Comment = new HashSet<Comment>();
            OderDetail = new HashSet<OderDetail>();
        }

        public int Id { get; set; }
        public int? CatId { get; set; }
        public string NameLap { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public byte? Quantity { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
        public string Image { get; set; }
        public string Memory { get; set; }
        public string Os { get; set; }
        public string CpuSpeed { get; set; }
        public string Camera { get; set; }
        public string Battery { get; set; }
        public string Waranty { get; set; }
        public string Bluetooth { get; set; }
        public string Wlan { get; set; }
        public int? SalePrice { get; set; }
        public DateTime? StartPromotion { get; set; }
        public DateTime? EndPromotion { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Categorys Cat { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<OderDetail> OderDetail { get; set; }
    }
}
