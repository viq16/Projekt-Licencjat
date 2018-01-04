using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Manager
{
    class DruzynaK
    {
        public int id { get; set; }
        public String Nazwa { get; set; }
        public int AttOvr { get; set; }
        public int MidOvr { get; set; }
        public int DefOvr { get; set; }
        public int StartBudget { get; set; }
        public DruzynaK(int id, String Nazwa, int AttOvr, int MidOvr, int DefOvr, int StartBudget)
        {
            this.id = id;
            this.Nazwa = Nazwa;
            this.AttOvr = AttOvr;
            this.MidOvr = MidOvr;
            this.DefOvr = DefOvr;
            this.StartBudget = StartBudget;
        }
    }
}
