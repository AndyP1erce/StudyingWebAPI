using System;

namespace WebApplication.DTOs
{
    public class GetBookDTO
    {
        public Guid AgencyId { get; set; }
        public Guid AuthorId { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }   
        public int Pages { get; set; }
    }

    public class PostBookDTO
    {
        public Guid AgencyId { get; set; }
        public Guid AuthorId { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }   
        public int Pages { get; set; }
    }
}