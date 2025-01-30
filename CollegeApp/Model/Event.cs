using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Event
    {
        
        public int Event_Id { get; set; }

        public string Event_PostedBy { get; set; } = "";

        public string Event_Title { get; set; } = "";

        public string Description { get; set; } = "";
      
        public DateTime Event_Date { get; set; }

        public string Location { get; set; } = "";
    }
}
