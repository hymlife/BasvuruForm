using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basvuruForm.Models.Entities
{
    public class EgitimDurum
    {
        public string LiseMezuniyet { get; set; }
        public string LiseMezuniyetTarih { get; set; }
        public string UniversiteMezuniyet { get; set; }
        public string UnivertsiteMezuniyetTarih { get; set; }
        public string LisansUstuMezuniyet { get; set; }
        public string LisansUstuMezuniyetTarih { get; set; }
        public string BitirilenKurslar { get; set; }
        public string YabanciDiller { get; set; }
        public string EhliyetDurumu { get; set; }
        public int Id { get; set; }
    }
}
