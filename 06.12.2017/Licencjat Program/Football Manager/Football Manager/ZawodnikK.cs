using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Manager
{
    class ZawodnikK
    {
        public int id { get; set; }
        public String Nazwisko { get; set; }
        public int SkillOvr { get; set; }
        public String Pozycja { get; set; }
        public int DruzynaId { get; set; }
        public ZawodnikK(int id, String Nazwisko, int SkillOvr, String Pozycja, int DruzynaId)
        {
            this.id = id;
            this.Nazwisko = Nazwisko;
            this.SkillOvr = SkillOvr;
            this.Pozycja = Pozycja;
            this.DruzynaId = DruzynaId;
        }
    }
}
