using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Contactdto
    {
        [Required]
        public int Contact_Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        public string? Contact_name { get; set; }
        [Required]
       
        public string? Contact_email { get; set; }
    }
}
