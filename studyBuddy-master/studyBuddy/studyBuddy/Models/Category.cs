using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace studyBuddy.Models
{
    public class Category
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="Kategoriyi boş geçemezsin.")]
        

        [DisplayName("Kategori adı:")]
        public string Name { get; set; }

        public virtual List<Pdf> Pdfs { get; set; }



    }
}
