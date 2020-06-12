using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studyBuddy.Models
{
    public class Rate
    {

        public int Id { get; set; }

        public int? Rating { get; set; }

        public virtual List<Pdf> Pdfs { get; set; }

    }
}
