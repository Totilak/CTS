using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS.Classes
{
    internal class TechnicalSpecification
    {
        public List<Paragraph> Paragraphs { get; set; }

        public TechnicalSpecification()
        {
            Paragraphs = new List<Paragraph>();
        }



        //Пример собранного текста из пунктов которые содержат подпункты.
        public string GenerateSpecificationText()
        {
            StringBuilder specificationText = new StringBuilder();

            foreach (var paragraph in Paragraphs)
            {
                specificationText.AppendLine($" Раздел: {paragraph.Number} {paragraph.Title}");

                foreach (var subparagraph in paragraph.Subparagraphs)
                {
                    specificationText.AppendLine($"     Подпункт: {subparagraph.Number} {subparagraph.Title}");
                    specificationText.AppendLine($"      {subparagraph.Text}");
                }

                specificationText.AppendLine();
            }

            return specificationText.ToString();
        }
    }
}
