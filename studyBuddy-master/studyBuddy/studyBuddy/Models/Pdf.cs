using Microsoft.AspNetCore.Http;
using studyBuddy.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace studyBuddy.Models
{
    public class Pdf
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Arşiv adı boş geçemezsin.")]
        
        [DisplayName("Arşiv adı:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Kategori  boş geçemezsin.")]

        [DisplayName("Kategori adı:")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "Dosya adı boş geçemezsin.")]
        
        [DisplayName("Dosya adı:")]
        public string ResimYolu { get; set; }
        
        [NotMapped]
        public IFormFile ResimDosyasi { get; set; }

        [Required(ErrorMessage = "Dönem  boş geçemezsin.")]

        [DisplayName("Dönem adı:")]
        public int TermId { get; set; }
        public Term Term { get; set; }


        


    }
}
