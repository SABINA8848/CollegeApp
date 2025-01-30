using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Setting
    {
        
        public int Setting_Id { get; set; }
       
        public int User_Id { get; set; }

        public string Theme { get; set; } = "";
        
        public string Notification { get; set; } = "";

    }
}
