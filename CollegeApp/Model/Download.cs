﻿using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class Download
    {
       
        public int Download_Id { get; set; }
       
        public int User_Id { get; set; }
        
        public int Resource_Id { get; set; }
        

        public DateTime Download_Date { get; set; }
    }
}
