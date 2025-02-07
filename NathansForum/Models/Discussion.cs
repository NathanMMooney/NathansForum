using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NathansForum.Models
{
    public class Discussion
    {
        public int DiscussionId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        [Display(Name = "Filename")]
        public string? ImageFileName { get; set; }

        [NotMapped]
        [Display(Name = "Image")]
        public IFormFile? ImageFile { get; set; } // Nullable for optional file uploads

        [Display(Name = "Created")]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        
        //Navigation
        public List<Comment>? Comments { get; set; }
    }
}
