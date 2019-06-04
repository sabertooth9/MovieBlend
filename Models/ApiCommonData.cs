﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBlend.Models
{
    public class ApiCommonData
    {
        [Required]
        public int id { get; set; }
        public string poster_path { get; set; }
        public bool adult { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
       // public int[] genre_ids { get; set; }
        
        public string original_title { get; set; }
        public string original_language { get; set; }
        public string title { get; set; }
        public string backdrop_path { get; set; }
        public double popularity { get; set; }
        public int vote_count { get; set; }
        public double vote_average { get; set; }
        public bool isAdded { get; set; }
        public string first_air_date { get; set; }
       // public string[] origin_country { get; set; }
        public string original_name { get; set; }
        public string name { get; set; }
        public bool isMovie { get; set; }
    }
}
