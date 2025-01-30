using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Resource
    {
        [Required]
        public int Resource_Id { get; set; }
        [Required]
        public int Course_Id { get; set; }
        [Required]
        public int Event_Id { get; set; }
    }
}
