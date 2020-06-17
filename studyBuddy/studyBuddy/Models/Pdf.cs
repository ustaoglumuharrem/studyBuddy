using Microsoft.AspNetCore.Http;
using studyBuddy.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace studyBuddy.Models
{
    public class Pdf
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

        public string ResimYolu { get; set; }
        
        [NotMapped]
        public IFormFile ResimDosyasi { get; set; }
        public Term Term { get; set; }


        public Rate Rate { get; set; }


    }
}
