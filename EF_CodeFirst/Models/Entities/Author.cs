using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models;

namespace EF_CodeFirst.Models
{
    public class Author
    {
        public int AuthorId { get; set; } 
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public DateTime AuthorDateOfBirth { get; set; }
        public bool IsDeleted { get; set; }
        public List<Book> Books { get; set; }
        
    }

}