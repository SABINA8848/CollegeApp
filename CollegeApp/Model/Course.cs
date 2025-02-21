﻿using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Course
    {
        
        public int Course_Id { get; set; }
        
        public string Title { get; set; } = "";
        
        public string Description { get; set; } = "";
        
        public int Credits { get; set; }
       
        public DateTime Start_date { get; set; }
       
        public DateTime End_date { get; set; }
    }
}
