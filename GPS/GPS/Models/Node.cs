﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace GPS.Models
{
    class Node
    {
        [Key]
        public int Id { get; set; }
        public string Label { get; set; }
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
    }
}
