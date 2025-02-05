﻿using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class UserDetail
    {
        
        public int User_Detail_Id { get; set; }
       
        public int User_Id { get; set; }
        
        public string? First_Name { get; set; }
        public string? Middle_Name { get; set ; }
        
        public string? Last_Name { get; set; }
        
        public int Contact_Number { get; set; }
        
        public string? Address { get; set; }
        
        public string? Country { get; set; }
        
        public int Zipcode { get; set; }
        
        public string? City { get; set; }
        
        public string State { get; set; } = "";
    }
}
