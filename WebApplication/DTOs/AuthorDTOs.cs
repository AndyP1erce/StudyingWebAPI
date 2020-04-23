using System;

namespace WebApplication.DTOs
{
    public class GetAuthorDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class PostAuthorDTO
    {
        public string Name { get; set; }
    }
}