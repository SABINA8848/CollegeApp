﻿using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class LogIn
    {
       
        public int Login_id { get; set; }
      
        public int User_Id { get; set; }
       
        public string Status { get; set; } = "";
       
        public DateTime Login_Time { get; set; }
    }
}
