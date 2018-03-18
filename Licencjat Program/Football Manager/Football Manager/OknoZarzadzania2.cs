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
        bool czyRozegranaKolejkaNr1 = false;
        bool czyRozegranaKolejkaNr2 = false;
        bool czyRozegranaKolejkaNr3 = false;
        bool czyRozegranaKolejkaNr4 = false;
        bool czyRozegranaKolejkaNr5 = false;
        bool czyRozegranaKolejkaNr6 = false;
        bool czyRozegranaKolejkaNr7 = false;
        bool czyRozegranaKolejkaNr8 = false;
        bool czyRozegranaKolejkaNr9 = false;
        bool czyRozegranaKolejkaNr10 = false;
        bool czyRozegranaKolejkaNr11 = false;
        bool czyRozegranaKolejkaNr12 = false;
        bool czyRozegranaKolejkaNr13 = false;
        bool czyRozegranaKolejkaNr14 = false;
        bool czyRozegranaKolejkaNr15 = false;
        bool czyRozegranaKolejkaNr16 = false;
        bool czyRozegranaKolejkaNr17 = false;
        bool czyRozegranaKolejkaNr18 = false;
        bool czyRozegranaKolejkaNr19 = false;

        public OknoZarzadzania2()
        {
            InitializeComponent();
            PrzepiszDruzynyDoListy();
            InicjalizacjaKolejkiNr1();
            czyscWyniki();
            bPoprzednia.Enabled = false;
        }
        //-------------------------------------
        public void ZmienNazwe(String nazwa2)
        {
            //label2.Text = nazwa2;
        }
        public void OtrzymajWyniki(List<String> ListaWynikowWyslana)
        {
            //ListaWynikowOtrzymana.AddRange(ListaWynikowWyslana);
            ListaWynikowOtrzymana = ListaWynikowWyslana.ToList(); // NAPRAWIA GENERATOR
            if(licznikZwrotowList==0)
            {
                czyRozegranaKolejkaNr1 = true;
            }
            else if (licznikZwrotowList == 1)
            {
                czyRozegranaKolejkaNr2 = true;
            }
            else if (licznikZwrotowList == 2)
            {
                czyRozegranaKolejkaNr3 = true;
            }
            else if (licznikZwrotowList == 3)
            {
                czyRozegranaKolejkaNr4 = true;
            }
            else if (licznikZwrotowList == 4)
            {
                czyRozegranaKolejkaNr5 = true;
            }
            else if (licznikZwrotowList == 5)
            {
                czyRozegranaKolejkaNr6 = true;
            }
            else if (licznikZwrotowList == 6)
            {
                czyRozegranaKolejkaNr7 = true;
            }
            else if (licznikZwrotowList == 7)
            {
                czyRozegranaKolejkaNr8 = true;
            }
            else if (licznikZwrotowList == 8)
            {
                czyRozegranaKolejkaNr9 = true;
            }
            else if (licznikZwrotowList == 9)
            {
                czyRozegranaKolejkaNr10 = true;
            }
            else if (licznikZwrotowList == 10)
            {
                czyRozegranaKolejkaNr11 = true;
            }
            else if (licznikZwrotowList == 11)
            {
                czyRozegranaKolejkaNr12 = true;
            }
            else if (licznikZwrotowList == 12)
            {
                czyRozegranaKolejkaNr13 = true;
            }
            else if (licznikZwrotowList == 13)
            {
                czyRozegranaKolejkaNr14 = true;
            }
            else if (licznikZwrotowList == 14)
            {
                czyRozegranaKolejkaNr15 = true;
            }
            else if (licznikZwrotowList == 15)
            {
                czyRozegranaKolejkaNr16 = true;
            }
            else if (licznikZwrotowList == 16)
            {
                czyRozegranaKolejkaNr17 = true;
            }
            else if (licznikZwrotowList == 17)
            {
                czyRozegranaKolejkaNr18 = true;
            }
            else if (licznikZwrotowList == 18)
            {
                czyRozegranaKolejkaNr19 = true;
            }
            InicjalizacjaKolejkiNr1();
            bPoprzednia.Enabled = false;
            licznikKolejek = 1;
            licznikZwrotowList++;
        }
        //--------------------------------------
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
        private void czyscWyniki()
        {
            label24.Text = "vs";
            label25.Text = "vs";
            label26.Text = "vs";
            label27.Text = "vs";
            label28.Text = "vs";
            label29.Text = "vs";
            label30.Text = "vs";
            label31.Text = "vs";
            label32.Text = "vs";
            label33.Text = "vs";
        }
        //--------------------------------------
        private void UzupelnienieKolejkiNr1()
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
        private void UzupelnienieKolejkiNr2()
        {
            label24.Text = ListaWynikowOtrzymana[10];
            label25.Text = ListaWynikowOtrzymana[11];
            label26.Text = ListaWynikowOtrzymana[12];
            label27.Text = ListaWynikowOtrzymana[13];
            label28.Text = ListaWynikowOtrzymana[14];
            label29.Text = ListaWynikowOtrzymana[15];
            label30.Text = ListaWynikowOtrzymana[16];
            label31.Text = ListaWynikowOtrzymana[17];
            label32.Text = ListaWynikowOtrzymana[18];
            label33.Text = ListaWynikowOtrzymana[19];
        }
        private void UzupelnienieKolejkiNr3()
        {
            label24.Text = ListaWynikowOtrzymana[20];
            label25.Text = ListaWynikowOtrzymana[21];
            label26.Text = ListaWynikowOtrzymana[22];
            label27.Text = ListaWynikowOtrzymana[23];
            label28.Text = ListaWynikowOtrzymana[24];
            label29.Text = ListaWynikowOtrzymana[25];
            label30.Text = ListaWynikowOtrzymana[26];
            label31.Text = ListaWynikowOtrzymana[27];
            label32.Text = ListaWynikowOtrzymana[28];
            label33.Text = ListaWynikowOtrzymana[29];
        }
        private void UzupelnienieKolejkiNr4()
        {
            label24.Text = ListaWynikowOtrzymana[30];
            label25.Text = ListaWynikowOtrzymana[31];
            label26.Text = ListaWynikowOtrzymana[32];
            label27.Text = ListaWynikowOtrzymana[33];
            label28.Text = ListaWynikowOtrzymana[34];
            label29.Text = ListaWynikowOtrzymana[35];
            label30.Text = ListaWynikowOtrzymana[36];
            label31.Text = ListaWynikowOtrzymana[37];
            label32.Text = ListaWynikowOtrzymana[38];
            label33.Text = ListaWynikowOtrzymana[39];
        }
        private void UzupelnienieKolejkiNr5()
        {
            label24.Text = ListaWynikowOtrzymana[40];
            label25.Text = ListaWynikowOtrzymana[41];
            label26.Text = ListaWynikowOtrzymana[42];
            label27.Text = ListaWynikowOtrzymana[43];
            label28.Text = ListaWynikowOtrzymana[44];
            label29.Text = ListaWynikowOtrzymana[45];
            label30.Text = ListaWynikowOtrzymana[46];
            label31.Text = ListaWynikowOtrzymana[47];
            label32.Text = ListaWynikowOtrzymana[48];
            label33.Text = ListaWynikowOtrzymana[49];
        }
        private void UzupelnienieKolejkiNr6()
        {
            label24.Text = ListaWynikowOtrzymana[50];
            label25.Text = ListaWynikowOtrzymana[51];
            label26.Text = ListaWynikowOtrzymana[52];
            label27.Text = ListaWynikowOtrzymana[53];
            label28.Text = ListaWynikowOtrzymana[54];
            label29.Text = ListaWynikowOtrzymana[55];
            label30.Text = ListaWynikowOtrzymana[56];
            label31.Text = ListaWynikowOtrzymana[57];
            label32.Text = ListaWynikowOtrzymana[58];
            label33.Text = ListaWynikowOtrzymana[59];
        }
        private void UzupelnienieKolejkiNr7()
        {
            label24.Text = ListaWynikowOtrzymana[60];
            label25.Text = ListaWynikowOtrzymana[61];
            label26.Text = ListaWynikowOtrzymana[62];
            label27.Text = ListaWynikowOtrzymana[63];
            label28.Text = ListaWynikowOtrzymana[64];
            label29.Text = ListaWynikowOtrzymana[65];
            label30.Text = ListaWynikowOtrzymana[66];
            label31.Text = ListaWynikowOtrzymana[67];
            label32.Text = ListaWynikowOtrzymana[68];
            label33.Text = ListaWynikowOtrzymana[69];
        }
        private void UzupelnienieKolejkiNr8()
        {
            label24.Text = ListaWynikowOtrzymana[70];
            label25.Text = ListaWynikowOtrzymana[71];
            label26.Text = ListaWynikowOtrzymana[72];
            label27.Text = ListaWynikowOtrzymana[73];
            label28.Text = ListaWynikowOtrzymana[74];
            label29.Text = ListaWynikowOtrzymana[75];
            label30.Text = ListaWynikowOtrzymana[76];
            label31.Text = ListaWynikowOtrzymana[77];
            label32.Text = ListaWynikowOtrzymana[78];
            label33.Text = ListaWynikowOtrzymana[79];
        }
        private void UzupelnienieKolejkiNr9()
        {
            label24.Text = ListaWynikowOtrzymana[80];
            label25.Text = ListaWynikowOtrzymana[81];
            label26.Text = ListaWynikowOtrzymana[82];
            label27.Text = ListaWynikowOtrzymana[83];
            label28.Text = ListaWynikowOtrzymana[84];
            label29.Text = ListaWynikowOtrzymana[85];
            label30.Text = ListaWynikowOtrzymana[86];
            label31.Text = ListaWynikowOtrzymana[87];
            label32.Text = ListaWynikowOtrzymana[88];
            label33.Text = ListaWynikowOtrzymana[89];
        }
        private void UzupelnienieKolejkiNr10()
        {
            label24.Text = ListaWynikowOtrzymana[90];
            label25.Text = ListaWynikowOtrzymana[91];
            label26.Text = ListaWynikowOtrzymana[92];
            label27.Text = ListaWynikowOtrzymana[93];
            label28.Text = ListaWynikowOtrzymana[94];
            label29.Text = ListaWynikowOtrzymana[95];
            label30.Text = ListaWynikowOtrzymana[96];
            label31.Text = ListaWynikowOtrzymana[97];
            label32.Text = ListaWynikowOtrzymana[98];
            label33.Text = ListaWynikowOtrzymana[99];
        }
        private void UzupelnienieKolejkiNr11()
        {
            label24.Text = ListaWynikowOtrzymana[100];
            label25.Text = ListaWynikowOtrzymana[101];
            label26.Text = ListaWynikowOtrzymana[102];
            label27.Text = ListaWynikowOtrzymana[103];
            label28.Text = ListaWynikowOtrzymana[104];
            label29.Text = ListaWynikowOtrzymana[105];
            label30.Text = ListaWynikowOtrzymana[106];
            label31.Text = ListaWynikowOtrzymana[107];
            label32.Text = ListaWynikowOtrzymana[108];
            label33.Text = ListaWynikowOtrzymana[109];
        }
        private void UzupelnienieKolejkiNr12()
        {
            label24.Text = ListaWynikowOtrzymana[110];
            label25.Text = ListaWynikowOtrzymana[111];
            label26.Text = ListaWynikowOtrzymana[112];
            label27.Text = ListaWynikowOtrzymana[113];
            label28.Text = ListaWynikowOtrzymana[114];
            label29.Text = ListaWynikowOtrzymana[115];
            label30.Text = ListaWynikowOtrzymana[116];
            label31.Text = ListaWynikowOtrzymana[117];
            label32.Text = ListaWynikowOtrzymana[118];
            label33.Text = ListaWynikowOtrzymana[119];
        }
        private void UzupelnienieKolejkiNr13()
        {
            label24.Text = ListaWynikowOtrzymana[120];
            label25.Text = ListaWynikowOtrzymana[121];
            label26.Text = ListaWynikowOtrzymana[122];
            label27.Text = ListaWynikowOtrzymana[123];
            label28.Text = ListaWynikowOtrzymana[124];
            label29.Text = ListaWynikowOtrzymana[125];
            label30.Text = ListaWynikowOtrzymana[126];
            label31.Text = ListaWynikowOtrzymana[127];
            label32.Text = ListaWynikowOtrzymana[128];
            label33.Text = ListaWynikowOtrzymana[129];
        }
        private void UzupelnienieKolejkiNr14()
        {
            label24.Text = ListaWynikowOtrzymana[130];
            label25.Text = ListaWynikowOtrzymana[131];
            label26.Text = ListaWynikowOtrzymana[132];
            label27.Text = ListaWynikowOtrzymana[133];
            label28.Text = ListaWynikowOtrzymana[134];
            label29.Text = ListaWynikowOtrzymana[135];
            label30.Text = ListaWynikowOtrzymana[136];
            label31.Text = ListaWynikowOtrzymana[137];
            label32.Text = ListaWynikowOtrzymana[138];
            label33.Text = ListaWynikowOtrzymana[139];
        }
        private void UzupelnienieKolejkiNr15()
        {
            label24.Text = ListaWynikowOtrzymana[140];
            label25.Text = ListaWynikowOtrzymana[141];
            label26.Text = ListaWynikowOtrzymana[142];
            label27.Text = ListaWynikowOtrzymana[143];
            label28.Text = ListaWynikowOtrzymana[144];
            label29.Text = ListaWynikowOtrzymana[145];
            label30.Text = ListaWynikowOtrzymana[146];
            label31.Text = ListaWynikowOtrzymana[147];
            label32.Text = ListaWynikowOtrzymana[148];
            label33.Text = ListaWynikowOtrzymana[149];
        }
        private void UzupelnienieKolejkiNr16()
        {
            label24.Text = ListaWynikowOtrzymana[150];
            label25.Text = ListaWynikowOtrzymana[151];
            label26.Text = ListaWynikowOtrzymana[152];
            label27.Text = ListaWynikowOtrzymana[153];
            label28.Text = ListaWynikowOtrzymana[154];
            label29.Text = ListaWynikowOtrzymana[155];
            label30.Text = ListaWynikowOtrzymana[156];
            label31.Text = ListaWynikowOtrzymana[157];
            label32.Text = ListaWynikowOtrzymana[158];
            label33.Text = ListaWynikowOtrzymana[159];
        }
        private void UzupelnienieKolejkiNr17()
        {
            label24.Text = ListaWynikowOtrzymana[160];
            label25.Text = ListaWynikowOtrzymana[161];
            label26.Text = ListaWynikowOtrzymana[162];
            label27.Text = ListaWynikowOtrzymana[163];
            label28.Text = ListaWynikowOtrzymana[164];
            label29.Text = ListaWynikowOtrzymana[165];
            label30.Text = ListaWynikowOtrzymana[166];
            label31.Text = ListaWynikowOtrzymana[167];
            label32.Text = ListaWynikowOtrzymana[168];
            label33.Text = ListaWynikowOtrzymana[169];
        }
        private void UzupelnienieKolejkiNr18()
        {
            label24.Text = ListaWynikowOtrzymana[170];
            label25.Text = ListaWynikowOtrzymana[171];
            label26.Text = ListaWynikowOtrzymana[172];
            label27.Text = ListaWynikowOtrzymana[173];
            label28.Text = ListaWynikowOtrzymana[174];
            label29.Text = ListaWynikowOtrzymana[175];
            label30.Text = ListaWynikowOtrzymana[176];
            label31.Text = ListaWynikowOtrzymana[177];
            label32.Text = ListaWynikowOtrzymana[178];
            label33.Text = ListaWynikowOtrzymana[179];
        }
        private void UzupelnienieKolejkiNr19()
        {
            label24.Text = ListaWynikowOtrzymana[180];
            label25.Text = ListaWynikowOtrzymana[181];
            label26.Text = ListaWynikowOtrzymana[182];
            label27.Text = ListaWynikowOtrzymana[183];
            label28.Text = ListaWynikowOtrzymana[184];
            label29.Text = ListaWynikowOtrzymana[185];
            label30.Text = ListaWynikowOtrzymana[186];
            label31.Text = ListaWynikowOtrzymana[187];
            label32.Text = ListaWynikowOtrzymana[188];
            label33.Text = ListaWynikowOtrzymana[189];
        }
        //---------------------------------------
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

            if (czyRozegranaKolejkaNr1 == true)
            {
                UzupelnienieKolejkiNr1();
            }
            else if (czyRozegranaKolejkaNr1 == false)
            {
                czyscWyniki();
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
            if (czyRozegranaKolejkaNr2 == true)
            {
                UzupelnienieKolejkiNr2();
            }
            else if (czyRozegranaKolejkaNr2 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr3 == true)
            {
                UzupelnienieKolejkiNr3();
            }
            else if (czyRozegranaKolejkaNr3 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr4 == true)
            {
                UzupelnienieKolejkiNr4();
            }
            else if (czyRozegranaKolejkaNr4 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr5 == true)
            {
                UzupelnienieKolejkiNr5();
            }
            else if (czyRozegranaKolejkaNr5 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr6 == true)
            {
                UzupelnienieKolejkiNr6();
            }
            else if (czyRozegranaKolejkaNr6 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr7 == true)
            {
                UzupelnienieKolejkiNr7();
            }
            else if (czyRozegranaKolejkaNr7 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr8 == true)
            {
                UzupelnienieKolejkiNr8();
            }
            else if (czyRozegranaKolejkaNr8 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr9 == true)
            {
                UzupelnienieKolejkiNr9();
            }
            else if (czyRozegranaKolejkaNr9 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr10 == true)
            {
                UzupelnienieKolejkiNr10();
            }
            else if (czyRozegranaKolejkaNr10 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr11 == true)
            {
                UzupelnienieKolejkiNr11();
            }
            else if (czyRozegranaKolejkaNr11 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr12 == true)
            {
                UzupelnienieKolejkiNr12();
            }
            else if (czyRozegranaKolejkaNr12 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr13 == true)
            {
                UzupelnienieKolejkiNr13();
            }
            else if (czyRozegranaKolejkaNr13 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr14 == true)
            {
                UzupelnienieKolejkiNr14();
            }
            else if (czyRozegranaKolejkaNr14 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr15 == true)
            {
                UzupelnienieKolejkiNr15();
            }
            else if (czyRozegranaKolejkaNr15 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr16 == true)
            {
                UzupelnienieKolejkiNr16();
            }
            else if (czyRozegranaKolejkaNr16 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr17 == true)
            {
                UzupelnienieKolejkiNr17();
            }
            else if (czyRozegranaKolejkaNr17 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr18 == true)
            {
                UzupelnienieKolejkiNr18();
            }
            else if (czyRozegranaKolejkaNr18 == false)
            {
                czyscWyniki();
            }
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
            if (czyRozegranaKolejkaNr19 == true)
            {
                UzupelnienieKolejkiNr19();
            }
            else if (czyRozegranaKolejkaNr19 == false)
            {
                czyscWyniki();
            }
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
