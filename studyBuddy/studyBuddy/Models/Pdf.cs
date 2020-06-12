using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studyBuddy.Models
{
    public class Pdf
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

        
        public Term Term { get; set; }


        public Rate Rate { get; set; }

        public virtual List<PdfLink> PdfLinks { get; set; }

    }
}
