﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp.Models
{
    public class Review
    {
        //properties for a review
        public int ID { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string ReviewCategory { get; set; }
        public string Content { get; set; }
        public string AltPicText { get; set; }
    }
}
