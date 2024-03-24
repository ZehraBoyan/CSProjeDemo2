using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public abstract class Personel
    {
        protected Personel() { }
        protected Personel(string name, string title, int calismaSaati, int saatlikUcret)
        {
            this.name = name;
            this.title = title;
            this.calismaSaati = calismaSaati;
            this.saatlikUcret = saatlikUcret;
        }

        public string name { get; set; }
        public string title { get; set; }
        public int calismaSaati { get; set; }
        public int saatlikUcret { get; set; }

        public abstract BordrdoDto MaasHesapla();
    }
}
