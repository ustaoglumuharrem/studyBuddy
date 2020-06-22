using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace studyBuddy.ViewModel
{
    public class SearchViewModel
    {
        [DisplayName("Arama metni:")]
        public string SearchText { get; set; }
        [DisplayName("Kategori adı:")]
        public int? CategoryId { get; set; }
        [DisplayName("Dönem:")]
        public int? TermId { get; set; }

        public List<Models.Pdf> Results { get; set; }
    }
}
