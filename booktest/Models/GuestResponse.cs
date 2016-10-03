using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace booktest.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify your gender")]
        public string Gender { get; set; }

        //[Required(ErrorMessage = "Please specify whether you'll attend")]
        //public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool Pet { get; set; }

        [Required(ErrorMessage = "Please specify whether you live in Detorit")]
        public bool? Live { get; set; }
    }
}