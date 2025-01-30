using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class News
    {
        
        public int News_Id { get; set; }
       
        public string Title { get; set; } = "";
        
        public string Content { get; set; } = "";
        
        public DateTime Publish_Date { get; set; }
        
        public string Auther { get; set; } = "";
    }
}
