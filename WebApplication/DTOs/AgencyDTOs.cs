using System;

namespace WebApplication.DTOs
{
    public class GetAgencyDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class PostAgencyDTO
    {
        public string Name { get; set; }
    }
}