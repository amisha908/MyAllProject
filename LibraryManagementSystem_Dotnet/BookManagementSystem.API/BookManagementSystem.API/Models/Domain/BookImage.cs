﻿namespace BookManagementSystem.API.Models.Domain
{
    public class BookImage
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
