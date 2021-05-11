﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RetroGG.net.Models
{
    public class Product
    {
        [Key]
        public Guid ProductID { get; set; }

        [MaxLength(32)]
        public string Name { get; set; }

        [MaxLength(512)]
        public string Description { get; set; }

        public StoredImage Image { get; set; }
    }
}
