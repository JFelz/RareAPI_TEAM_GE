﻿namespace TEAMGE_API.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int PostId { get; set; }
        public string? Content { get; set; }
        public int UserId { get; set; }
    }
}
