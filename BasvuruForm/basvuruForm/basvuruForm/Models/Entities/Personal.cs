using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basvuruForm.Models.Entities
{
    public class Personal
    {
        public int id { get; set; }

        public string AdSoyad { get; set; }
        public string DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public bool Cinsiyet { get; set; }
        public bool MedeniDurum { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
    }
}
