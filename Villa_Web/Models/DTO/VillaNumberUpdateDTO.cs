﻿using System.ComponentModel.DataAnnotations;

namespace Villa_Web.Models
{
    public class VillaNumberUpdateDTO
    {
        [Required]

        public int VillaNo { get; set; }
        [Required]
        public int VillaID { get; set; } 
        public string SpecialDetails { get; set; }
    }
}