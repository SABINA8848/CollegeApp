using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Userdto
    {
        [Required]
        public int User_Id { get; set; }
        [Required]
        public string? User_Name { get; set; }
        [Required]
        public string? User_Email { get; set; }
        [Required]
        public string? Password_Hash { get; set; }
        [Required]
        public DateTime? Created_At { get; set; }
    }
}
