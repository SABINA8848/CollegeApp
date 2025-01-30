using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Contact
    {
       
        public int Contact_Id {  get; set; }
       
        public int User_Id {  get; set; }

        public string Contact_name { get; set; } = "";

        public string Contact_email { get; set; } = "";
    }
}
