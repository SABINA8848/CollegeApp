using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Downloaddto
    {
        [Required]
        public int Download_Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        [Required]
        public int Resource_Id { get; set; }
        [Required]

        public DateTime Download_Date { get; set; } 

    }
}
