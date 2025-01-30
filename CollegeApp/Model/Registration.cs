﻿using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Registration
    {
        
        public int Registration_Id { get; set; }
        
        public int User_Id { get; set; }
        
        public int Course_Id { get; set; }
       
        public int Event_Id { get; set; }
        
        public DateTime Registration_Date { get; set; }
    }
}
