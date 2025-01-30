using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class LogIndto
    {
        [Required]
        public int Login_id { get; set; }
        [Required]
        public int User_Id { get; set; }
        [Required]
        public string? Status { get; set; }
        [Required]
        public DateTime Login_Time { get; set; }
    }
}
