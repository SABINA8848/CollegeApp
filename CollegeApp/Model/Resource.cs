﻿using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Resource
    {
        
        public int Resource_Id { get; set; }
        
        public int Course_Id { get; set; }
        
        public int Event_Id { get; set; }
    }
}
