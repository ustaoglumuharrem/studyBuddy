using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace studyBuddy.Models
{
    public class Term
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Dönem boş geçemezsin.")]
        
        [DisplayName("Dönem adı:")]
        public string Name { get; set; }

        public virtual List<Pdf> Pdfs { get; set; }


    }
}
