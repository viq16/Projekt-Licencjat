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
    public partial class OknoZarzadzania2 : UserControl
    {
        int licznikKolejek=1, licznikZwrotowList=0;
        List<DruzynaK> ListaDruzyn = new List<DruzynaK>();
        List<String> ListaWynikowOtrzymana = new List<String>();
        BazaDataContext BazaFM = new BazaDataContext();
        bool Kolejka1Rozegrana = false;
        public OknoZarzadzania2()
        {
            InitializeComponent();
            PrzepiszDruzynyDoListy();
            InicjalizacjaKolejkiNr1();
            bPoprzednia.Enabled = false;
        }
        //---------------------------------
        public void ZmienNazwe(String nazwa2)
        {
            //label2.Text = nazwa2;
        }
        public void OtrzymajWyniki(List<String> ListaWynikowWyslana)
        {
            ListaWynikowOtrzymana.AddRange(ListaWynikowWyslana);
            if(licznikZwrotowList==0)
            {
                Kolejka1Rozegrana = true;
            }
            licznikZwrotowList++;
        }
        //---------------------------------
        private void PrzepiszDruzynyDoListy()
        {
            int idL;
            String NazwaL;
            int AttOvrL;
            int MidOvrL;
            int DefOvrL;
            int StartBudgetL;
            foreach (Druzyna zz in BazaFM.Druzynas)
            {
                idL = zz.Id;
                NazwaL = zz.Nazwa;
                AttOvrL = zz.AttOvr;
                MidOvrL = zz.MidOvr;
                DefOvrL = zz.DefOvr;
                StartBudgetL = zz.StartBudget;

                DruzynaK z = new DruzynaK(idL, NazwaL, AttOvrL, MidOvrL, DefOvrL, StartBudgetL);
                ListaDruzyn.Add(z);
            }
        }
        private void UzupelnienieKolejkinr1()
        {
            
        }
        private void InicjalizacjaKolejkiNr1()
        {
            label23.Text = "Kolejka 1";
            label3.Text = ListaDruzyn[0].Nazwa;
            label4.Text = ListaDruzyn[1].Nazwa;
            label5.Text = ListaDruzyn[2].Nazwa;
            label6.Text = ListaDruzyn[3].Nazwa;
            label7.Text = ListaDruzyn[4].Nazwa;
            label8.Text = ListaDruzyn[5].Nazwa;
            label9.Text = ListaDruzyn[6].Nazwa;
            label10.Text = ListaDruzyn[7].Nazwa;
            label11.Text = ListaDruzyn[8].Nazwa;
            label12.Text = ListaDruzyn[9].Nazwa;

            label13.Text = ListaDruzyn[10].Nazwa;
            label14.Text = ListaDruzyn[11].Nazwa;
            label15.Text = ListaDruzyn[12].Nazwa;
            label16.Text = ListaDruzyn[13].Nazwa;
            label17.Text = ListaDruzyn[14].Nazwa;
            label18.Text = ListaDruzyn[15].Nazwa;
            label19.Text = ListaDruzyn[16].Nazwa;
            label20.Text = ListaDruzyn[17].Nazwa;
            label21.Text = ListaDruzyn[18].Nazwa;
            label22.Text = ListaDruzyn[19].Nazwa;

            if (Kolejka1Rozegrana == true)
            {
                label24.Text = ListaWynikowOtrzymana[0];
                label25.Text = ListaWynikowOtrzymana[1];
                label26.Text = ListaWynikowOtrzymana[2];
                label27.Text = ListaWynikowOtrzymana[3];
                label28.Text = ListaWynikowOtrzymana[4];
                label29.Text = ListaWynikowOtrzymana[5];
                label30.Text = ListaWynikowOtrzymana[6];
                label31.Text = ListaWynikowOtrzymana[7];
                label32.Text = ListaWynikowOtrzymana[8];
                label33.Text = ListaWynikowOtrzymana[9];
            }
        }
        private void InicjalizacjaKolejkiNr2()
        {
            label23.Text = "Kolejka 2";
            label3.Text = ListaDruzyn[11].Nazwa;
            label4.Text = ListaDruzyn[12].Nazwa;
            label5.Text = ListaDruzyn[13].Nazwa;
            label6.Text = ListaDruzyn[14].Nazwa;
            label7.Text = ListaDruzyn[15].Nazwa;
            label8.Text = ListaDruzyn[16].Nazwa;
            label9.Text = ListaDruzyn[17].Nazwa;
            label10.Text = ListaDruzyn[18].Nazwa;
            label11.Text = ListaDruzyn[19].Nazwa;
            label12.Text = ListaDruzyn[10].Nazwa;

            label13.Text = ListaDruzyn[0].Nazwa;
            label14.Text = ListaDruzyn[1].Nazwa;
            label15.Text = ListaDruzyn[2].Nazwa;
            label16.Text = ListaDruzyn[3].Nazwa;
            label17.Text = ListaDruzyn[4].Nazwa;
            label18.Text = ListaDruzyn[5].Nazwa;
            label19.Text = ListaDruzyn[6].Nazwa;
            label20.Text = ListaDruzyn[7].Nazwa;
            label21.Text = ListaDruzyn[8].Nazwa;
            label22.Text = ListaDruzyn[9].Nazwa;
        }
        private void InicjalizacjaKolejkiNr3()
        {
            label23.Text = "Kolejka 3";
            label3.Text = ListaDruzyn[0].Nazwa;
            label4.Text = ListaDruzyn[1].Nazwa;
            label5.Text = ListaDruzyn[2].Nazwa;
            label6.Text = ListaDruzyn[3].Nazwa;
            label7.Text = ListaDruzyn[4].Nazwa;
            label8.Text = ListaDruzyn[5].Nazwa;
            label9.Text = ListaDruzyn[6].Nazwa;
            label10.Text = ListaDruzyn[7].Nazwa;
            label11.Text = ListaDruzyn[8].Nazwa;
            label12.Text = ListaDruzyn[9].Nazwa;

            label13.Text = ListaDruzyn[12].Nazwa;
            label14.Text = ListaDruzyn[13].Nazwa;
            label15.Text = ListaDruzyn[14].Nazwa;
            label16.Text = ListaDruzyn[15].Nazwa;
            label17.Text = ListaDruzyn[16].Nazwa;
            label18.Text = ListaDruzyn[17].Nazwa;
            label19.Text = ListaDruzyn[18].Nazwa;
            label20.Text = ListaDruzyn[19].Nazwa;
            label21.Text = ListaDruzyn[10].Nazwa;
            label22.Text = ListaDruzyn[11].Nazwa;
        }
        private void InicjalizacjaKolejkiNr4()
        {
            label23.Text = "Kolejka 4";
            label3.Text = ListaDruzyn[13].Nazwa;
            label4.Text = ListaDruzyn[14].Nazwa;
            label5.Text = ListaDruzyn[15].Nazwa;
            label6.Text = ListaDruzyn[16].Nazwa;
            label7.Text = ListaDruzyn[17].Nazwa;
            label8.Text = ListaDruzyn[18].Nazwa;
            label9.Text = ListaDruzyn[19].Nazwa;
            label10.Text = ListaDruzyn[10].Nazwa;
            label11.Text = ListaDruzyn[11].Nazwa;
            label12.Text = ListaDruzyn[12].Nazwa;

            label13.Text = ListaDruzyn[0].Nazwa;
            label14.Text = ListaDruzyn[1].Nazwa;
            label15.Text = ListaDruzyn[2].Nazwa;
            label16.Text = ListaDruzyn[3].Nazwa;
            label17.Text = ListaDruzyn[4].Nazwa;
            label18.Text = ListaDruzyn[5].Nazwa;
            label19.Text = ListaDruzyn[6].Nazwa;
            label20.Text = ListaDruzyn[7].Nazwa;
            label21.Text = ListaDruzyn[8].Nazwa;
            label22.Text = ListaDruzyn[9].Nazwa;
        }
        private void InicjalizacjaKolejkiNr5()
        {
            label23.Text = "Kolejka 5";
            label3.Text = ListaDruzyn[0].Nazwa;
            label4.Text = ListaDruzyn[1].Nazwa;
            label5.Text = ListaDruzyn[2].Nazwa;
            label6.Text = ListaDruzyn[3].Nazwa;
            label7.Text = ListaDruzyn[4].Nazwa;
            label8.Text = ListaDruzyn[5].Nazwa;
            label9.Text = ListaDruzyn[6].Nazwa;
            label10.Text = ListaDruzyn[7].Nazwa;
            label11.Text = ListaDruzyn[8].Nazwa;
            label12.Text = ListaDruzyn[9].Nazwa;

            label13.Text = ListaDruzyn[14].Nazwa;
            label14.Text = ListaDruzyn[15].Nazwa;
            label15.Text = ListaDruzyn[16].Nazwa;
            label16.Text = ListaDruzyn[17].Nazwa;
            label17.Text = ListaDruzyn[18].Nazwa;
            label18.Text = ListaDruzyn[19].Nazwa;
            label19.Text = ListaDruzyn[10].Nazwa;
            label20.Text = ListaDruzyn[11].Nazwa;
            label21.Text = ListaDruzyn[12].Nazwa;
            label22.Text = ListaDruzyn[13].Nazwa;
        }
        private void InicjalizacjaKolejkiNr6()
        {
            label23.Text = "Kolejka 6";
            label3.Text = ListaDruzyn[15].Nazwa;
            label4.Text = ListaDruzyn[16].Nazwa;
            label5.Text = ListaDruzyn[17].Nazwa;
            label6.Text = ListaDruzyn[18].Nazwa;
            label7.Text = ListaDruzyn[19].Nazwa;
            label8.Text = ListaDruzyn[10].Nazwa;
            label9.Text = ListaDruzyn[11].Nazwa;
            label10.Text = ListaDruzyn[12].Nazwa;
            label11.Text = ListaDruzyn[13].Nazwa;
            label12.Text = ListaDruzyn[14].Nazwa;

            label13.Text = ListaDruzyn[0].Nazwa;
            label14.Text = ListaDruzyn[1].Nazwa;
            label15.Text = ListaDruzyn[2].Nazwa;
            label16.Text = ListaDruzyn[3].Nazwa;
            label17.Text = ListaDruzyn[4].Nazwa;
            label18.Text = ListaDruzyn[5].Nazwa;
            label19.Text = ListaDruzyn[6].Nazwa;
            label20.Text = ListaDruzyn[7].Nazwa;
            label21.Text = ListaDruzyn[8].Nazwa;
            label22.Text = ListaDruzyn[9].Nazwa;
        }
        private void InicjalizacjaKolejkiNr7()
        {
            label23.Text = "Kolejka 7";
            label3.Text = ListaDruzyn[0].Nazwa;
            label4.Text = ListaDruzyn[1].Nazwa;
            label5.Text = ListaDruzyn[2].Nazwa;
            label6.Text = ListaDruzyn[3].Nazwa;
            label7.Text = ListaDruzyn[4].Nazwa;
            label8.Text = ListaDruzyn[5].Nazwa;
            label9.Text = ListaDruzyn[6].Nazwa;
            label10.Text = ListaDruzyn[7].Nazwa;
            label11.Text = ListaDruzyn[8].Nazwa;
            label12.Text = ListaDruzyn[9].Nazwa;

            label13.Text = ListaDruzyn[16].Nazwa;
            label14.Text = ListaDruzyn[17].Nazwa;
            label15.Text = ListaDruzyn[18].Nazwa;
            label16.Text = ListaDruzyn[19].Nazwa;
            label17.Text = ListaDruzyn[10].Nazwa;
            label18.Text = ListaDruzyn[11].Nazwa;
            label19.Text = ListaDruzyn[12].Nazwa;
            label20.Text = ListaDruzyn[13].Nazwa;
            label21.Text = ListaDruzyn[14].Nazwa;
            label22.Text = ListaDruzyn[15].Nazwa;
        }
        private void InicjalizacjaKolejkiNr8()
        {
            label23.Text = "Kolejka 8";
            label3.Text = ListaDruzyn[17].Nazwa;
            label4.Text = ListaDruzyn[18].Nazwa;
            label5.Text = ListaDruzyn[19].Nazwa;
            label6.Text = ListaDruzyn[10].Nazwa;
            label7.Text = ListaDruzyn[11].Nazwa;
            label8.Text = ListaDruzyn[12].Nazwa;
            label9.Text = ListaDruzyn[13].Nazwa;
            label10.Text = ListaDruzyn[14].Nazwa;
            label11.Text = ListaDruzyn[15].Nazwa;
            label12.Text = ListaDruzyn[16].Nazwa;

            label13.Text = ListaDruzyn[0].Nazwa;
            label14.Text = ListaDruzyn[1].Nazwa;
            label15.Text = ListaDruzyn[2].Nazwa;
            label16.Text = ListaDruzyn[3].Nazwa;
            label17.Text = ListaDruzyn[4].Nazwa;
            label18.Text = ListaDruzyn[5].Nazwa;
            label19.Text = ListaDruzyn[6].Nazwa;
            label20.Text = ListaDruzyn[7].Nazwa;
            label21.Text = ListaDruzyn[8].Nazwa;
            label22.Text = ListaDruzyn[9].Nazwa;
        }
        private void InicjalizacjaKolejkiNr9()
        {
            label23.Text = "Kolejka 9";
            label3.Text = ListaDruzyn[0].Nazwa;
            label4.Text = ListaDruzyn[1].Nazwa;
            label5.Text = ListaDruzyn[2].Nazwa;
            label6.Text = ListaDruzyn[3].Nazwa;
            label7.Text = ListaDruzyn[4].Nazwa;
            label8.Text = ListaDruzyn[5].Nazwa;
            label9.Text = ListaDruzyn[6].Nazwa;
            label10.Text = ListaDruzyn[7].Nazwa;
            label11.Text = ListaDruzyn[8].Nazwa;
            label12.Text = ListaDruzyn[9].Nazwa;

            label13.Text = ListaDruzyn[18].Nazwa;
            label14.Text = ListaDruzyn[19].Nazwa;
            label15.Text = ListaDruzyn[10].Nazwa;
            label16.Text = ListaDruzyn[11].Nazwa;
            label17.Text = ListaDruzyn[12].Nazwa;
            label18.Text = ListaDruzyn[13].Nazwa;
            label19.Text = ListaDruzyn[14].Nazwa;
            label20.Text = ListaDruzyn[15].Nazwa;
            label21.Text = ListaDruzyn[16].Nazwa;
            label22.Text = ListaDruzyn[17].Nazwa;
        }
        private void InicjalizacjaKolejkiNr10()
        {
            label23.Text = "Kolejka 10";
            label3.Text = ListaDruzyn[19].Nazwa;
            label4.Text = ListaDruzyn[10].Nazwa;
            label5.Text = ListaDruzyn[11].Nazwa;
            label6.Text = ListaDruzyn[12].Nazwa;
            label7.Text = ListaDruzyn[13].Nazwa;
            label8.Text = ListaDruzyn[14].Nazwa;
            label9.Text = ListaDruzyn[15].Nazwa;
            label10.Text = ListaDruzyn[16].Nazwa;
            label11.Text = ListaDruzyn[17].Nazwa;
            label12.Text = ListaDruzyn[18].Nazwa;

            label13.Text = ListaDruzyn[0].Nazwa;
            label14.Text = ListaDruzyn[1].Nazwa;
            label15.Text = ListaDruzyn[2].Nazwa;
            label16.Text = ListaDruzyn[3].Nazwa;
            label17.Text = ListaDruzyn[4].Nazwa;
            label18.Text = ListaDruzyn[5].Nazwa;
            label19.Text = ListaDruzyn[6].Nazwa;
            label20.Text = ListaDruzyn[7].Nazwa;
            label21.Text = ListaDruzyn[8].Nazwa;
            label22.Text = ListaDruzyn[9].Nazwa;
        }
        private void InicjalizacjaKolejkiNr11()
        {
            label23.Text = "Kolejka 11";
            label3.Text = ListaDruzyn[0].Nazwa;
            label4.Text = ListaDruzyn[2].Nazwa;
            label5.Text = ListaDruzyn[4].Nazwa;
            label6.Text = ListaDruzyn[6].Nazwa;
            label7.Text = ListaDruzyn[8].Nazwa;
            label8.Text = ListaDruzyn[10].Nazwa;
            label9.Text = ListaDruzyn[12].Nazwa;
            label10.Text = ListaDruzyn[14].Nazwa;
            label11.Text = ListaDruzyn[16].Nazwa;
            label12.Text = ListaDruzyn[18].Nazwa;

            label13.Text = ListaDruzyn[1].Nazwa;
            label14.Text = ListaDruzyn[3].Nazwa;
            label15.Text = ListaDruzyn[5].Nazwa;
            label16.Text = ListaDruzyn[7].Nazwa;
            label17.Text = ListaDruzyn[9].Nazwa;
            label18.Text = ListaDruzyn[11].Nazwa;
            label19.Text = ListaDruzyn[13].Nazwa;
            label20.Text = ListaDruzyn[15].Nazwa;
            label21.Text = ListaDruzyn[17].Nazwa;
            label22.Text = ListaDruzyn[19].Nazwa;
        }
        private void InicjalizacjaKolejkiNr12()
        {
            label23.Text = "Kolejka 12";
            label3.Text = ListaDruzyn[0].Nazwa;
            label4.Text = ListaDruzyn[1].Nazwa;
            label5.Text = ListaDruzyn[2].Nazwa;
            label6.Text = ListaDruzyn[6].Nazwa;
            label7.Text = ListaDruzyn[7].Nazwa;
            label8.Text = ListaDruzyn[10].Nazwa;
            label9.Text = ListaDruzyn[11].Nazwa;
            label10.Text = ListaDruzyn[12].Nazwa;
            label11.Text = ListaDruzyn[16].Nazwa;
            label12.Text = ListaDruzyn[17].Nazwa;

            label13.Text = ListaDruzyn[3].Nazwa;
            label14.Text = ListaDruzyn[4].Nazwa;
            label15.Text = ListaDruzyn[5].Nazwa;
            label16.Text = ListaDruzyn[9].Nazwa;
            label17.Text = ListaDruzyn[8].Nazwa;
            label18.Text = ListaDruzyn[13].Nazwa;
            label19.Text = ListaDruzyn[14].Nazwa;
            label20.Text = ListaDruzyn[15].Nazwa;
            label21.Text = ListaDruzyn[19].Nazwa;
            label22.Text = ListaDruzyn[18].Nazwa;
        }
        private void InicjalizacjaKolejkiNr13()
        {
            label23.Text = "Kolejka 13";
            label3.Text = ListaDruzyn[0].Nazwa;
            label4.Text = ListaDruzyn[1].Nazwa;
            label5.Text = ListaDruzyn[4].Nazwa;
            label6.Text = ListaDruzyn[5].Nazwa;
            label7.Text = ListaDruzyn[7].Nazwa;
            label8.Text = ListaDruzyn[10].Nazwa;
            label9.Text = ListaDruzyn[11].Nazwa;
            label10.Text = ListaDruzyn[14].Nazwa;
            label11.Text = ListaDruzyn[15].Nazwa;
            label12.Text = ListaDruzyn[17].Nazwa;

            label13.Text = ListaDruzyn[2].Nazwa;
            label14.Text = ListaDruzyn[3].Nazwa;
            label15.Text = ListaDruzyn[6].Nazwa;
            label16.Text = ListaDruzyn[8].Nazwa;
            label17.Text = ListaDruzyn[9].Nazwa;
            label18.Text = ListaDruzyn[12].Nazwa;
            label19.Text = ListaDruzyn[13].Nazwa;
            label20.Text = ListaDruzyn[16].Nazwa;
            label21.Text = ListaDruzyn[18].Nazwa;
            label22.Text = ListaDruzyn[19].Nazwa;
        }
        private void InicjalizacjaKolejkiNr14()
        {
            label23.Text = "Kolejka 14";
            label3.Text = ListaDruzyn[0].Nazwa;
            label4.Text = ListaDruzyn[1].Nazwa;
            label5.Text = ListaDruzyn[2].Nazwa;
            label6.Text = ListaDruzyn[3].Nazwa;
            label7.Text = ListaDruzyn[5].Nazwa;
            label8.Text = ListaDruzyn[10].Nazwa;
            label9.Text = ListaDruzyn[11].Nazwa;
            label10.Text = ListaDruzyn[12].Nazwa;
            label11.Text = ListaDruzyn[13].Nazwa;
            label12.Text = ListaDruzyn[15].Nazwa;

            label13.Text = ListaDruzyn[4].Nazwa;
            label14.Text = ListaDruzyn[8].Nazwa;
            label15.Text = ListaDruzyn[6].Nazwa;
            label16.Text = ListaDruzyn[7].Nazwa;
            label17.Text = ListaDruzyn[9].Nazwa;
            label18.Text = ListaDruzyn[14].Nazwa;
            label19.Text = ListaDruzyn[15].Nazwa;
            label20.Text = ListaDruzyn[16].Nazwa;
            label21.Text = ListaDruzyn[18].Nazwa;
            label22.Text = ListaDruzyn[19].Nazwa;
        }
        private void InicjalizacjaKolejkiNr15()
        {
            label23.Text = "Kolejka 15";
            label3.Text = ListaDruzyn[0].Nazwa;
            label4.Text = ListaDruzyn[1].Nazwa;
            label5.Text = ListaDruzyn[2].Nazwa;
            label6.Text = ListaDruzyn[3].Nazwa;
            label7.Text = ListaDruzyn[4].Nazwa;
            label8.Text = ListaDruzyn[10].Nazwa;
            label9.Text = ListaDruzyn[11].Nazwa;
            label10.Text = ListaDruzyn[12].Nazwa;
            label11.Text = ListaDruzyn[13].Nazwa;
            label12.Text = ListaDruzyn[14].Nazwa;

            label13.Text = ListaDruzyn[5].Nazwa;
            label14.Text = ListaDruzyn[6].Nazwa;
            label15.Text = ListaDruzyn[7].Nazwa;
            label16.Text = ListaDruzyn[8].Nazwa;
            label17.Text = ListaDruzyn[9].Nazwa;
            label18.Text = ListaDruzyn[15].Nazwa;
            label19.Text = ListaDruzyn[16].Nazwa;
            label20.Text = ListaDruzyn[17].Nazwa;
            label21.Text = ListaDruzyn[18].Nazwa;
            label22.Text = ListaDruzyn[19].Nazwa;
        }
        private void InicjalizacjaKolejkiNr16()
        {
            label23.Text = "Kolejka 16";
            label3.Text = ListaDruzyn[0].Nazwa;
            label4.Text = ListaDruzyn[1].Nazwa;
            label5.Text = ListaDruzyn[3].Nazwa;
            label6.Text = ListaDruzyn[5].Nazwa;
            label7.Text = ListaDruzyn[2].Nazwa;
            label8.Text = ListaDruzyn[10].Nazwa;
            label9.Text = ListaDruzyn[11].Nazwa;
            label10.Text = ListaDruzyn[13].Nazwa;
            label11.Text = ListaDruzyn[15].Nazwa;
            label12.Text = ListaDruzyn[12].Nazwa;

            label13.Text = ListaDruzyn[8].Nazwa;
            label14.Text = ListaDruzyn[7].Nazwa;
            label15.Text = ListaDruzyn[4].Nazwa;
            label16.Text = ListaDruzyn[6].Nazwa;
            label17.Text = ListaDruzyn[9].Nazwa;
            label18.Text = ListaDruzyn[18].Nazwa;
            label19.Text = ListaDruzyn[17].Nazwa;
            label20.Text = ListaDruzyn[14].Nazwa;
            label21.Text = ListaDruzyn[16].Nazwa;
            label22.Text = ListaDruzyn[19].Nazwa;
        }
        private void InicjalizacjaKolejkiNr17()
        {
            label23.Text = "Kolejka 17";
            label3.Text = ListaDruzyn[1].Nazwa;
            label4.Text = ListaDruzyn[3].Nazwa;
            label5.Text = ListaDruzyn[5].Nazwa;
            label6.Text = ListaDruzyn[6].Nazwa;
            label7.Text = ListaDruzyn[0].Nazwa;
            label8.Text = ListaDruzyn[11].Nazwa;
            label9.Text = ListaDruzyn[13].Nazwa;
            label10.Text = ListaDruzyn[15].Nazwa;
            label11.Text = ListaDruzyn[16].Nazwa;
            label12.Text = ListaDruzyn[10].Nazwa;

            label13.Text = ListaDruzyn[2].Nazwa;
            label14.Text = ListaDruzyn[4].Nazwa;
            label15.Text = ListaDruzyn[7].Nazwa;
            label16.Text = ListaDruzyn[8].Nazwa;
            label17.Text = ListaDruzyn[9].Nazwa;
            label18.Text = ListaDruzyn[12].Nazwa;
            label19.Text = ListaDruzyn[14].Nazwa;
            label20.Text = ListaDruzyn[17].Nazwa;
            label21.Text = ListaDruzyn[18].Nazwa;
            label22.Text = ListaDruzyn[19].Nazwa;
        }
        private void InicjalizacjaKolejkiNr18()
        {
            label23.Text = "Kolejka 18";
            label3.Text = ListaDruzyn[1].Nazwa;
            label4.Text = ListaDruzyn[3].Nazwa;
            label5.Text = ListaDruzyn[4].Nazwa;
            label6.Text = ListaDruzyn[0].Nazwa;
            label7.Text = ListaDruzyn[2].Nazwa;
            label8.Text = ListaDruzyn[11].Nazwa;
            label9.Text = ListaDruzyn[13].Nazwa;
            label10.Text = ListaDruzyn[14].Nazwa;
            label11.Text = ListaDruzyn[10].Nazwa;
            label12.Text = ListaDruzyn[12].Nazwa;

            label13.Text = ListaDruzyn[9].Nazwa;
            label14.Text = ListaDruzyn[5].Nazwa;
            label15.Text = ListaDruzyn[7].Nazwa;
            label16.Text = ListaDruzyn[6].Nazwa;
            label17.Text = ListaDruzyn[8].Nazwa;
            label18.Text = ListaDruzyn[19].Nazwa;
            label19.Text = ListaDruzyn[15].Nazwa;
            label20.Text = ListaDruzyn[17].Nazwa;
            label21.Text = ListaDruzyn[16].Nazwa;
            label22.Text = ListaDruzyn[19].Nazwa;
        }
        private void InicjalizacjaKolejkiNr19()
        {
            label23.Text = "Kolejka 19";
            label3.Text = ListaDruzyn[0].Nazwa;
            label4.Text = ListaDruzyn[1].Nazwa;
            label5.Text = ListaDruzyn[3].Nazwa;
            label6.Text = ListaDruzyn[4].Nazwa;
            label7.Text = ListaDruzyn[3].Nazwa;
            label8.Text = ListaDruzyn[10].Nazwa;
            label9.Text = ListaDruzyn[11].Nazwa;
            label10.Text = ListaDruzyn[13].Nazwa;
            label11.Text = ListaDruzyn[14].Nazwa;
            label12.Text = ListaDruzyn[13].Nazwa;

            label13.Text = ListaDruzyn[7].Nazwa;
            label14.Text = ListaDruzyn[5].Nazwa;
            label15.Text = ListaDruzyn[6].Nazwa;
            label16.Text = ListaDruzyn[8].Nazwa;
            label17.Text = ListaDruzyn[9].Nazwa;
            label18.Text = ListaDruzyn[17].Nazwa;
            label19.Text = ListaDruzyn[15].Nazwa;
            label20.Text = ListaDruzyn[16].Nazwa;
            label21.Text = ListaDruzyn[18].Nazwa;
            label22.Text = ListaDruzyn[19].Nazwa;
        }
        private void bPoprzednia_Click(object sender, EventArgs e)
        {
            if(licznikKolejek==2)
            {
                InicjalizacjaKolejkiNr1();
            }
            if (licznikKolejek == 3)
            {
                InicjalizacjaKolejkiNr2();
            }
            if (licznikKolejek == 4)
            {
                InicjalizacjaKolejkiNr3();
            }
            if (licznikKolejek == 5)
            {
                InicjalizacjaKolejkiNr4();
            }
            if (licznikKolejek == 6)
            {
                InicjalizacjaKolejkiNr5();
            }
            if (licznikKolejek == 7)
            {
                InicjalizacjaKolejkiNr6();
            }
            if (licznikKolejek == 8)
            {
                InicjalizacjaKolejkiNr7();
            }
            if (licznikKolejek == 9)
            {
                InicjalizacjaKolejkiNr8();
            }
            if (licznikKolejek == 10)
            {
                InicjalizacjaKolejkiNr9();
            }
            if (licznikKolejek == 11)
            {
                InicjalizacjaKolejkiNr10();
            }
            if (licznikKolejek == 12)
            {
                InicjalizacjaKolejkiNr11();
            }
            if (licznikKolejek == 13)
            {
                InicjalizacjaKolejkiNr12();
            }
            if (licznikKolejek == 14)
            {
                InicjalizacjaKolejkiNr13();
            }
            if (licznikKolejek == 15)
            {
                InicjalizacjaKolejkiNr14();
            }
            if (licznikKolejek == 16)
            {
                InicjalizacjaKolejkiNr15();
            }
            if (licznikKolejek == 17)
            {
                InicjalizacjaKolejkiNr16();
            }
            if (licznikKolejek == 18)
            {
                InicjalizacjaKolejkiNr17();
            }
            if (licznikKolejek == 19)
            {
                InicjalizacjaKolejkiNr18();
            }
            //----------------------------
            licznikKolejek--;
            if(licznikKolejek==1)
            {
                bPoprzednia.Enabled = false;
            }
            if (licznikKolejek != 19)
            {
                bNastepna.Enabled = true;
            }
        }

        private void bNastepna_Click(object sender, EventArgs e)
        {
            if(licznikKolejek==1)
            {
                InicjalizacjaKolejkiNr2();
            }
            if (licznikKolejek == 2)
            {
                InicjalizacjaKolejkiNr3();
            }
            if (licznikKolejek == 3)
            {
                InicjalizacjaKolejkiNr4();
            }
            if (licznikKolejek == 4)
            {
                InicjalizacjaKolejkiNr5();
            }
            if (licznikKolejek == 5)
            {
                InicjalizacjaKolejkiNr6();
            }
            if (licznikKolejek == 6)
            {
                InicjalizacjaKolejkiNr7();
            }
            if (licznikKolejek == 7)
            {
                InicjalizacjaKolejkiNr8();
            }
            if (licznikKolejek == 8)
            {
                InicjalizacjaKolejkiNr9();
            }
            if (licznikKolejek == 9)
            {
                InicjalizacjaKolejkiNr10();
            }
            if (licznikKolejek == 10)
            {
                InicjalizacjaKolejkiNr11();
            }
            if (licznikKolejek == 11)
            {
                InicjalizacjaKolejkiNr12();
            }
            if (licznikKolejek == 12)
            {
                InicjalizacjaKolejkiNr13();
            }
            if (licznikKolejek == 13)
            {
                InicjalizacjaKolejkiNr14();
            }
            if (licznikKolejek == 14)
            {
                InicjalizacjaKolejkiNr15();
            }
            if (licznikKolejek == 15)
            {
                InicjalizacjaKolejkiNr16();
            }
            if (licznikKolejek == 16)
            {
                InicjalizacjaKolejkiNr17();
            }
            if (licznikKolejek == 17)
            {
                InicjalizacjaKolejkiNr18();
            }
            if (licznikKolejek == 18)
            {
                InicjalizacjaKolejkiNr19();
            }
            //----------------------------
            licznikKolejek++;
            if(licznikKolejek!=1)
            {
                bPoprzednia.Enabled = true;
            }
            if(licznikKolejek==38)
            {
                bNastepna.Enabled = false;
            }
        }
    }
}
