using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Manager
{
    public class DruzynaPunkty
    {
        public String Nazwa { get; set; }
        public int Punkty { get; set; }
        public DruzynaPunkty(String Nazwa, int Punkty)
        {
            this.Nazwa = Nazwa;
            this.Punkty = Punkty;
        }
    }
}
