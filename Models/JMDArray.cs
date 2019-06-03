﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBlend.Models
{
    public class JMDArray
    {
        public JsonMovieData[] results { get; set; }
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
    }
}
