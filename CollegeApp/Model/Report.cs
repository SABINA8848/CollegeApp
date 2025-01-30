using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Report
    {
        
        public int Report_Id { get; set; }

        public string User_Id { get; set; } = "";

        public string Report_Type { get; set; } = "";
        
        public DateTime Generated_date { get; set; }

        public string Content { get; set; } = "";
    }
}
