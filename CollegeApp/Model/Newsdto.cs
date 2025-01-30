using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Newsdto
    {
        [Required]
        public int News_Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }
        [Required]
        public DateTime Publish_Date { get; set; }
        [Required]
        public string? Auther { get; set; }
    }
}
