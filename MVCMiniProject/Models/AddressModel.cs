﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVCMiniProject.Models
{
    public class AddressModel
    {
        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [Display(Name = "ZipCode")]
        [StringLength(10, MinimumLength =5)]
        public string ZipCode { get; set; }
    }
}
