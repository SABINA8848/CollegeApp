using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Coursedto
    {
        [Required]
        public int Course_Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int Credits { get; set; }
        [Required]
        public DateTime Start_date { get; set; }
        [Required]
        public DateTime End_date { get; set; }
    }
}
