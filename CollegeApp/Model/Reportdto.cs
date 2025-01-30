using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Reportdto
    {
        [Required]
        public int Report_Id { get; set; }
        [Required]
        public string? User_Id { get; set; }
        [Required]
        public string? Report_Type { get; set; }
        [Required]
        public DateTime? Generated_date { get; set; }
        [Required]
        public string? Content { get; set; }
    }
}
