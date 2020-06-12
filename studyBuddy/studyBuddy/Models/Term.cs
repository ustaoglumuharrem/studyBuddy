using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studyBuddy.Models
{
    public class Term
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Pdf> Pdfs { get; set; }


    }
}
