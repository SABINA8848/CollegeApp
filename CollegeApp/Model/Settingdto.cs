using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Settingdto
    {
        [Required]
        public int Setting_Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        [Required]
        public string? Theme { get; set; }
        [Required]
        public string? Notification { get; set; }
    }
}
