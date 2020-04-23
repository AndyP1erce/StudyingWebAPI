using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.DAL.Models
{
    public class Agency
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        public virtual IList<Book> Books { get; set; }
    }
}