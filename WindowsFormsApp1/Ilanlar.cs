using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class Ilanlar
    {
        public Guid ID { get; set; }
        public string marka { get; set; }
        public string seri { get; set; }
        public string model { get; set; }
        public string yil { get; set; }
        public string yakit { get; set; }
        public string vites { get; set; }
        public string km { get; set; }
        public string Resim { get; set; }
        public string Renk { get; set; }
        public string Sehir { get; set; }
        public string Garanti { get; set; }
        public string Durumu { get; set; }
        public string Kimden { get; set; }
        public string ekbilgi { get; set; }

    }
    public static class IlanlarListe
    {
        public static List<Ilanlar> IlanListesi = new List<Ilanlar>();
    }
}