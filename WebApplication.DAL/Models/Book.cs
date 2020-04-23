using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.DAL.Models
{
    public class Book
    {
        [Key]
        public Guid AgencyId { get; set; }
        [Key]
        public Guid AuthorId { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }   
        public int Pages { get; set; }
        
        public virtual Agency Agency { get; set; }
        public virtual Author Author { get; set; }
    }
}