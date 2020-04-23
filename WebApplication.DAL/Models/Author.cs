using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.DAL.Models
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public virtual List<Book> Books { get; set; }
    }
}