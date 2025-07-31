using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Address
    {
        public string Street { get; set; }
        public string huisnummer { get; set; }
        public Provincie provincie { get; set; }

        public enum Provincie
        {
            Antwerpen, Henegouwen, Limburg, Luik, Luxemburg,
            Namen, OostVlaanderen, VlaamsBrabant, WaalsBrabant, WestVlaanderen
        }
    }
}
