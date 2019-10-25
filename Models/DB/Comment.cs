using System;
using System.Collections.Generic;

namespace TaoShop.Models.DB
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int? LaptopId { get; set; }
        public string FullName { get; set; }
        public DateTime? CommentTime { get; set; }
        public string CommentContent { get; set; }
        public string PhoneNumber { get; set; }

        public Laptop Laptop { get; set; }
    }
}
