﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGrage.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string RegNo { get; set; }
        public string Color { get; set; }
        public int NoWheels { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public DateTime Date { get; set; }
        
    }
}