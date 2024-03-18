using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Classes
{
    internal class Paragraph
    {
        public string Title { get; set; }
        public string Number { get; set; }
        public List<Subparagraph> Subparagraphs { get; set; } // Изменение модификатора доступа

        public Paragraph()
        {
            Subparagraphs = new List<Subparagraph>();
        }
    }
}
