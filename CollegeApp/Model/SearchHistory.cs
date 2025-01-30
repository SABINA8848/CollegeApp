using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class SearchHistory
    {
        [Required]
        public int Search_Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        [Required]
        public string? Keyword { get; set; }
        [Required]
        public DateTime? Search_Date { get; set; }
    }
}
