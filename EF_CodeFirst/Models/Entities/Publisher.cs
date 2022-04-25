using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models;

namespace EF_CodeFirst.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public string PublisherCity { get; set; }
        public string PublisherAmil { get; set; }
        public List<Book> Books { get; set; }
        public bool IsDeleted { get; set; }
    }
}