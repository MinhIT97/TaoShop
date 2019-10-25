using System;
using System.Collections.Generic;

namespace TaoShop.Models.DB
{
    public partial class Categorys
    {
        public Categorys()
        {
            Laptop = new HashSet<Laptop>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Parent { get; set; }
        public string Slug { get; set; }
        public byte? Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public ICollection<Laptop> Laptop { get; set; }
    }
}
