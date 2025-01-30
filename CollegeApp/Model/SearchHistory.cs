﻿using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Model
{
    public class SearchHistory
    {
        
        public int Search_Id { get; set; }
      
        public int User_Id { get; set; }
        
        public string? Keyword { get; set; }
        
        public DateTime? Search_Date { get; set; }
    }
}
