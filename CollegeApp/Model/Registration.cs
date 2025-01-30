using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Registration
    {
        [Required]
        public int Registration_Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        [Required]
        public int Course_Id { get; set; }
        [Required]
        public int Event_Id { get; set; }
        [Required]
        public DateTime Registration_Date { get; set; }
    }
}
