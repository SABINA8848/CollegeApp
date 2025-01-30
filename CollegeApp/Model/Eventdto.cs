using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Eventdto
    {
        [Required]
        public int Event_Id { get; set; }
        [Required]
        public string? Event_PostedBy { get; set; }
        [Required]
        public string? Event_Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public DateTime Event_Date { get; set; }
        [Required]
        public string? Location { get; set; }
    }
}
