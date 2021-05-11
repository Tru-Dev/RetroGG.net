using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RetroGG.net.Models
{
    public class StoredImage
    {
        [Key]
        public Guid ImageID { get; set; }

        [MaxLength(32)]
        public string Name { get; set; }

        [MaxLength(1 << 20)] // == 1 MiB
        public byte[] ImageData { get; set; }
    }
}
