﻿using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.API.Models.DTO
{
    public class CreateBookRequestDTO
    {
        [Required] public string Name { get; set; }
        public string Description { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
        public Guid[] Genres { get; set; }
    }
}
