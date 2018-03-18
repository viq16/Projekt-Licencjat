using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Manager
{
    public partial class OknoZarzadzania3 : UserControl
    {
        List<DruzynaK> ListaDruzyn = new List<DruzynaK>();
        //List<DruzynaK> PosortowanaListaDruzyn = new List<DruzynaK>();
        List<DruzynaPunkty> PosortowanaListaDruzyn = new List<DruzynaPunkty>();
        BazaDataContext BazaFM = new BazaDataContext();

        public OknoZarzadzania3()
        {
            InitializeComponent();
            PrzepiszDruzynyDoListy();
            InicjalizacjaTabeli();
        }
        //---------------------------------
        public void ZmienNazwe2(String nazwa)
        {
            //label2.Text = nazwa;
        }
        //---------------------------------
        public void OtrzymajPunkty(List<DruzynaPunkty> d)
        {
            //foreach(DruzynaK zz in ListaDruzyn)
            foreach(DruzynaPunkty zz in PosortowanaListaDruzyn)
            {
                foreach(DruzynaPunkty dd in d)
                {
                    if(zz.Nazwa == dd.Nazwa)
                    {
                        zz.Punkty += dd.Punkty; // Punkty
                        break;
                    }
                }
            }
            InicjalizacjaPosortowanychPunktow();
        }
        private void SortowanieTabeli()
        {
            //PosortowanaListaDruzyn = ListaDruzyn.OrderByDescending(o => o.StartBudget).ToList();
            PosortowanaListaDruzyn = PosortowanaListaDruzyn.OrderByDescending(o => o.Punkty).ToList();
        }
        private void AktualizujPunkty()
        {
            foreach(DruzynaK zz in ListaDruzyn)
            {
                if (label1.Text == zz.Nazwa)
                {
                    label22.Text = zz.StartBudget.ToString();
                }
                else if (label2.Text == zz.Nazwa)
                {
                    label23.Text = zz.StartBudget.ToString();
                }
                else if (label3.Text == zz.Nazwa)
                {
                    label24.Text = zz.StartBudget.ToString();
                }
                else if (label4.Text == zz.Nazwa)
                {
                    label25.Text = zz.StartBudget.ToString();
                }
                else if (label5.Text == zz.Nazwa)
                {
                    label26.Text = zz.StartBudget.ToString();
                }
                else if (label6.Text == zz.Nazwa)
                {
                    label27.Text = zz.StartBudget.ToString();
                }
                else if (label7.Text == zz.Nazwa)
                {
                    label28.Text = zz.StartBudget.ToString();
                }
                else if (label8.Text == zz.Nazwa)
                {
                    label29.Text = zz.StartBudget.ToString();
                }
                else if (label9.Text == zz.Nazwa)
                {
                    label30.Text = zz.StartBudget.ToString();
                }
                else if (label10.Text == zz.Nazwa)
                {
                    label31.Text = zz.StartBudget.ToString();
                }
                else if (label11.Text == zz.Nazwa)
                {
                    label32.Text = zz.StartBudget.ToString();
                }
                else if (label12.Text == zz.Nazwa)
                {
                    label33.Text = zz.StartBudget.ToString();
                }
                else if (label13.Text == zz.Nazwa)
                {
                    label34.Text = zz.StartBudget.ToString();
                }
                else if (label14.Text == zz.Nazwa)
                {
                    label35.Text = zz.StartBudget.ToString();
                }
                else if (label15.Text == zz.Nazwa)
                {
                    label36.Text = zz.StartBudget.ToString();
                }
                else if (label16.Text == zz.Nazwa)
                {
                    label37.Text = zz.StartBudget.ToString();
                }
                else if (label17.Text == zz.Nazwa)
                {
                    label38.Text = zz.StartBudget.ToString();
                }
                else if (label18.Text == zz.Nazwa)
                {
                    label39.Text = zz.StartBudget.ToString();
                }
                else if (label19.Text == zz.Nazwa)
                {
                    label40.Text = zz.StartBudget.ToString();
                }
                else if (label20.Text == zz.Nazwa)
                {
                    label41.Text = zz.StartBudget.ToString();
                }
            }
        }// Niewykorzystane
        private void InicjalizacjaTabeli()
        {
            label1.Text = ListaDruzyn[0].Nazwa;
            label2.Text = ListaDruzyn[1].Nazwa;
            label3.Text = ListaDruzyn[2].Nazwa;
            label4.Text = ListaDruzyn[3].Nazwa;
            label5.Text = ListaDruzyn[4].Nazwa;
            label6.Text = ListaDruzyn[5].Nazwa;
            label7.Text = ListaDruzyn[6].Nazwa;
            label8.Text = ListaDruzyn[7].Nazwa;
            label9.Text = ListaDruzyn[8].Nazwa;
            label10.Text = ListaDruzyn[9].Nazwa;
            label11.Text = ListaDruzyn[10].Nazwa;
            label12.Text = ListaDruzyn[11].Nazwa;
            label13.Text = ListaDruzyn[12].Nazwa;
            label14.Text = ListaDruzyn[13].Nazwa;
            label15.Text = ListaDruzyn[14].Nazwa;
            label16.Text = ListaDruzyn[15].Nazwa;
            label17.Text = ListaDruzyn[16].Nazwa;
            label18.Text = ListaDruzyn[17].Nazwa;
            label19.Text = ListaDruzyn[18].Nazwa;
            label20.Text = ListaDruzyn[19].Nazwa;
        }
        private void InicjalizacjaPosortowanychPunktow()
        {
            SortowanieTabeli();
            label1.Text = PosortowanaListaDruzyn[0].Nazwa;
            label2.Text = PosortowanaListaDruzyn[1].Nazwa;
            label3.Text = PosortowanaListaDruzyn[2].Nazwa;
            label4.Text = PosortowanaListaDruzyn[3].Nazwa;
            label5.Text = PosortowanaListaDruzyn[4].Nazwa;
            label6.Text = PosortowanaListaDruzyn[5].Nazwa;
            label7.Text = PosortowanaListaDruzyn[6].Nazwa;
            label8.Text = PosortowanaListaDruzyn[7].Nazwa;
            label9.Text = PosortowanaListaDruzyn[8].Nazwa;
            label10.Text = PosortowanaListaDruzyn[9].Nazwa;
            label11.Text = PosortowanaListaDruzyn[10].Nazwa;
            label12.Text = PosortowanaListaDruzyn[11].Nazwa;
            label13.Text = PosortowanaListaDruzyn[12].Nazwa;
            label14.Text = PosortowanaListaDruzyn[13].Nazwa;
            label15.Text = PosortowanaListaDruzyn[14].Nazwa;
            label16.Text = PosortowanaListaDruzyn[15].Nazwa;
            label17.Text = PosortowanaListaDruzyn[16].Nazwa;
            label18.Text = PosortowanaListaDruzyn[17].Nazwa;
            label19.Text = PosortowanaListaDruzyn[18].Nazwa;
            label20.Text = PosortowanaListaDruzyn[19].Nazwa;

            label22.Text = PosortowanaListaDruzyn[0].Punkty.ToString();
            label23.Text = PosortowanaListaDruzyn[1].Punkty.ToString();
            label24.Text = PosortowanaListaDruzyn[2].Punkty.ToString();
            label25.Text = PosortowanaListaDruzyn[3].Punkty.ToString();
            label26.Text = PosortowanaListaDruzyn[4].Punkty.ToString();
            label27.Text = PosortowanaListaDruzyn[5].Punkty.ToString();
            label28.Text = PosortowanaListaDruzyn[6].Punkty.ToString();
            label29.Text = PosortowanaListaDruzyn[7].Punkty.ToString();
            label30.Text = PosortowanaListaDruzyn[8].Punkty.ToString();
            label31.Text = PosortowanaListaDruzyn[9].Punkty.ToString();
            label32.Text = PosortowanaListaDruzyn[10].Punkty.ToString();
            label33.Text = PosortowanaListaDruzyn[11].Punkty.ToString();
            label34.Text = PosortowanaListaDruzyn[12].Punkty.ToString();
            label35.Text = PosortowanaListaDruzyn[13].Punkty.ToString();
            label36.Text = PosortowanaListaDruzyn[14].Punkty.ToString();
            label37.Text = PosortowanaListaDruzyn[15].Punkty.ToString();
            label38.Text = PosortowanaListaDruzyn[16].Punkty.ToString();
            label39.Text = PosortowanaListaDruzyn[17].Punkty.ToString();
            label40.Text = PosortowanaListaDruzyn[18].Punkty.ToString();
            label41.Text = PosortowanaListaDruzyn[19].Punkty.ToString();
        }
        private void PrzepiszDruzynyDoListy()
        {
            int idL;
            String NazwaL;
            int AttOvrL;
            int MidOvrL;
            int DefOvrL;
            int IloscPunktowL;
            foreach (Druzyna zz in BazaFM.Druzynas)
            {
                idL = zz.Id;
                NazwaL = zz.Nazwa;
                AttOvrL = zz.AttOvr;
                MidOvrL = zz.MidOvr;
                DefOvrL = zz.DefOvr;
                IloscPunktowL = 0;

                DruzynaK z = new DruzynaK(idL, NazwaL, AttOvrL, MidOvrL, DefOvrL, IloscPunktowL);
                DruzynaPunkty k = new DruzynaPunkty(NazwaL, IloscPunktowL);
                ListaDruzyn.Add(z);
                PosortowanaListaDruzyn.Add(k);
            }
        }
    }
}
