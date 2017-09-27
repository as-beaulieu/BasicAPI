﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElementAPI.Models
{
    public class LandmarkModelUpdate
    {
        [Required(ErrorMessage = "Need a real name.")]
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
    }
}
