﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutDetails { get; set; }
        public string AboutDetails2 { get; set; }
        public string AboutImage { get; set; }
        public string AboutImage2 { get; set; }
        public string AboutMapLocation { get; set; }
        public bool AboutStatus { get; set; }
    }
}