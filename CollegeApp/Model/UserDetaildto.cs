using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class UserDetaildto
    {
        [Required]
        public int User_Detail_Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        [Required]
        public string? First_Name { get; set; }
        public string? Middle_Name { get; set; }
        [Required]
        public string? Last_Name { get; set; }
        [Required]
        public int Contact_Number { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? Country { get; set; }
        [Required]
        public int Zipcode { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string State { get; set; } = "";
    }
}
