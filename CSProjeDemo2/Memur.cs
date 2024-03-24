using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Memur : Personel
    {
        public Memur() { }
        public Memur(string name, string title, int calismaSaati, int saatlikUcret, int derece) : base(name, title, calismaSaati, saatlikUcret)
        {
            this.derece = derece;
        }

        public int derece { get; set; }

        public override BordrdoDto MaasHesapla()
        {
            BordrdoDto bordo = new();
            bordo.PersonelIsmi = name;
            bordo.CalismaSaati = calismaSaati;
            bordo.AnaOdeme = saatlikUcret * calismaSaati;
            if (calismaSaati < 180) bordo.Mesai = 0;
            else bordo.Mesai = (calismaSaati - 180) * saatlikUcret;
            bordo.ToplamOdeme = bordo.Mesai + bordo.AnaOdeme;

            return bordo;
        }
    }
}
