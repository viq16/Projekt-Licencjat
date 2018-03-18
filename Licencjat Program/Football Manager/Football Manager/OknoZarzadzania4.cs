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
    public partial class OknoZarzadzania4 : UserControl
    {
        public delegate void delegat3(List<String> d);
        public event delegat3 wyslijWyniki;
        public delegate void delegat4(List<DruzynaPunkty> d);
        public event delegat4 dodajPunkty;

        int pktyTeam1, pktyTeam2, licznikCzasu=0, roznicaAttDef, roznicaDefAtt, roznicaMid, goleTeam1, goleTeam2, licznikKolejek=1, licznikMeczyWKolejce=1;
        String NazwaWybranejDruzyny, Wynik;
        List<DruzynaK> ListaDruzyn = new List<DruzynaK>();
        List<String> ListaWynikow = new List<String>();
        List<DruzynaPunkty> ListaDruzynaPunkty = new List<DruzynaPunkty>();
        BazaDataContext BazaFM = new BazaDataContext();
        private static readonly Random rand = new Random();
        private static readonly object syncLock = new object();
        DruzynaK Team1, Team2;
        public OknoZarzadzania4()
        {
            InitializeComponent();
            PrzepiszDruzynyDoListy();
        }
        //---------------------------------
        public void ZmienNazwe2(String nazwa)
        {
            //label2.Text = nazwa;
            NazwaWybranejDruzyny = nazwa;
        }
        //---------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            licznikCzasu++;
            //label3.Text = licznikCzasu.ToString();
            if(licznikCzasu==90)
            {
                timer1.Stop();
                SymulacjaMeczu();
            }
        }
        private void TimerReset()
        {
            timer1.Stop();
            timer1.Start();
        }
        private void bRozpocznij_Click(object sender, EventArgs e)
        {
            //TimerReset();
            //licznikCzasu = 0;
            //label4.Text = Team1.Nazwa;
            //label5.Text = Team2.Nazwa;
            SymulacjaKolejki();
            wyslijWyniki?.Invoke(ListaWynikow as List<String>);
            dodajPunkty?.Invoke(ListaDruzynaPunkty as List<DruzynaPunkty>);
            ListaDruzynaPunkty.Clear();
        }
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
        private void PoznajRywali()
        {
            if(licznikKolejek==1)
            {
                if (licznikMeczyWKolejce == 1) 
                {
                    Team1 = ListaDruzyn[0];
                    Team2 = ListaDruzyn[10];
                }
                else if (licznikMeczyWKolejce == 2)
                {
                    Team1 = ListaDruzyn[1];
                    Team2 = ListaDruzyn[11];
                }
                else if (licznikMeczyWKolejce == 3)
                {
                    Team1 = ListaDruzyn[2];
                    Team2 = ListaDruzyn[12];
                }
                else if (licznikMeczyWKolejce == 4)
                {
                    Team1 = ListaDruzyn[3];
                    Team2 = ListaDruzyn[13];
                }
                else if (licznikMeczyWKolejce == 5)
                {
                    Team1 = ListaDruzyn[4];
                    Team2 = ListaDruzyn[14];
                }
                else if (licznikMeczyWKolejce == 6)
                {
                    Team1 = ListaDruzyn[5];
                    Team2 = ListaDruzyn[15];
                }
                else if (licznikMeczyWKolejce == 7)
                {
                    Team1 = ListaDruzyn[6];
                    Team2 = ListaDruzyn[16];
                }
                else if (licznikMeczyWKolejce == 8)
                {
                    Team1 = ListaDruzyn[7];
                    Team2 = ListaDruzyn[17];
                }
                else if (licznikMeczyWKolejce == 9)
                {
                    Team1 = ListaDruzyn[8];
                    Team2 = ListaDruzyn[18];
                }
                else if (licznikMeczyWKolejce == 10)
                {
                    Team1 = ListaDruzyn[9];
                    Team2 = ListaDruzyn[19];
                    licznikKolejek++;
                    licznikMeczyWKolejce = 0;
                }
                licznikMeczyWKolejce++;
            }
            //----------------------------
            else if (licznikKolejek == 2)
            {
                if (licznikMeczyWKolejce == 1)
                {
                    Team1 = ListaDruzyn[11];
                    Team2 = ListaDruzyn[0];
                }
                else if (licznikMeczyWKolejce == 2)
                {
                    Team1 = ListaDruzyn[12];
                    Team2 = ListaDruzyn[1];
                }
                else if (licznikMeczyWKolejce == 3)
                {
                    Team1 = ListaDruzyn[13];
                    Team2 = ListaDruzyn[2];
                }
                else if (licznikMeczyWKolejce == 4)
                {
                    Team1 = ListaDruzyn[14];
                    Team2 = ListaDruzyn[3];
                }
                else if (licznikMeczyWKolejce == 5)
                {
                    Team1 = ListaDruzyn[15];
                    Team2 = ListaDruzyn[4];
                }
                else if (licznikMeczyWKolejce == 6)
                {
                    Team1 = ListaDruzyn[16];
                    Team2 = ListaDruzyn[5];
                }
                else if (licznikMeczyWKolejce == 7)
                {
                    Team1 = ListaDruzyn[17];
                    Team2 = ListaDruzyn[6];
                }
                else if (licznikMeczyWKolejce == 8)
                {
                    Team1 = ListaDruzyn[18];
                    Team2 = ListaDruzyn[7];
                }
                else if (licznikMeczyWKolejce == 9)
                {
                    Team1 = ListaDruzyn[19];
                    Team2 = ListaDruzyn[8];
                }
                else if (licznikMeczyWKolejce == 10)
                {
                    Team1 = ListaDruzyn[10];
                    Team2 = ListaDruzyn[9];
                    licznikKolejek++;
                    licznikMeczyWKolejce = 0;
                }
                licznikMeczyWKolejce++;
            }
            //---------------------------
            else if (licznikKolejek == 3)
            {
                if (licznikMeczyWKolejce == 1)
                {
                    Team1 = ListaDruzyn[0];
                    Team2 = ListaDruzyn[12];
                }
                else if (licznikMeczyWKolejce == 2)
                {
                    Team1 = ListaDruzyn[1];
                    Team2 = ListaDruzyn[13];
                }
                else if (licznikMeczyWKolejce == 3)
                {
                    Team1 = ListaDruzyn[2];
                    Team2 = ListaDruzyn[14];
                }
                else if (licznikMeczyWKolejce == 4)
                {
                    Team1 = ListaDruzyn[3];
                    Team2 = ListaDruzyn[15];
                }
                else if (licznikMeczyWKolejce == 5)
                {
                    Team1 = ListaDruzyn[4];
                    Team2 = ListaDruzyn[16];
                }
                else if (licznikMeczyWKolejce == 6)
                {
                    Team1 = ListaDruzyn[5];
                    Team2 = ListaDruzyn[17];
                }
                else if (licznikMeczyWKolejce == 7)
                {
                    Team1 = ListaDruzyn[6];
                    Team2 = ListaDruzyn[18];
                }
                else if (licznikMeczyWKolejce == 8)
                {
                    Team1 = ListaDruzyn[7];
                    Team2 = ListaDruzyn[19];
                }
                else if (licznikMeczyWKolejce == 9)
                {
                    Team1 = ListaDruzyn[8];
                    Team2 = ListaDruzyn[10];
                }
                else if (licznikMeczyWKolejce == 10)
                {
                    Team1 = ListaDruzyn[9];
                    Team2 = ListaDruzyn[11];
                    licznikKolejek++;
                    licznikMeczyWKolejce = 0;
                }
                licznikMeczyWKolejce++;
            }
            //----------------------------
            else if (licznikKolejek == 4)
            {
                if (licznikMeczyWKolejce == 1)
                {
                    Team1 = ListaDruzyn[13];
                    Team2 = ListaDruzyn[0];
                }
                else if (licznikMeczyWKolejce == 2)
                {
                    Team1 = ListaDruzyn[14];
                    Team2 = ListaDruzyn[1];
                }
                else if (licznikMeczyWKolejce == 3)
                {
                    Team1 = ListaDruzyn[15];
                    Team2 = ListaDruzyn[2];
                }
                else if (licznikMeczyWKolejce == 4)
                {
                    Team1 = ListaDruzyn[16];
                    Team2 = ListaDruzyn[3];
                }
                else if (licznikMeczyWKolejce == 5)
                {
                    Team1 = ListaDruzyn[17];
                    Team2 = ListaDruzyn[4];
                }
                else if (licznikMeczyWKolejce == 6)
                {
                    Team1 = ListaDruzyn[18];
                    Team2 = ListaDruzyn[5];
                }
                else if (licznikMeczyWKolejce == 7)
                {
                    Team1 = ListaDruzyn[19];
                    Team2 = ListaDruzyn[6];
                }
                else if (licznikMeczyWKolejce == 8)
                {
                    Team1 = ListaDruzyn[10];
                    Team2 = ListaDruzyn[7];
                }
                else if (licznikMeczyWKolejce == 9)
                {
                    Team1 = ListaDruzyn[11];
                    Team2 = ListaDruzyn[8];
                }
                else if (licznikMeczyWKolejce == 10)
                {
                    Team1 = ListaDruzyn[12];
                    Team2 = ListaDruzyn[9];
                    licznikKolejek++;
                    licznikMeczyWKolejce = 0;
                }
                licznikMeczyWKolejce++;
            }
            //----------------------------
            else if (licznikKolejek == 5)
            {
                if (licznikMeczyWKolejce == 1)
                {
                    Team1 = ListaDruzyn[0];
                    Team2 = ListaDruzyn[14];
                }
                else if (licznikMeczyWKolejce == 2)
                {
                    Team1 = ListaDruzyn[1];
                    Team2 = ListaDruzyn[15];
                }
                else if (licznikMeczyWKolejce == 3)
                {
                    Team1 = ListaDruzyn[2];
                    Team2 = ListaDruzyn[16];
                }
                else if (licznikMeczyWKolejce == 4)
                {
                    Team1 = ListaDruzyn[3];
                    Team2 = ListaDruzyn[17];
                }
                else if (licznikMeczyWKolejce == 5)
                {
                    Team1 = ListaDruzyn[4];
                    Team2 = ListaDruzyn[18];
                }
                else if (licznikMeczyWKolejce == 6)
                {
                    Team1 = ListaDruzyn[5];
                    Team2 = ListaDruzyn[19];
                }
                else if (licznikMeczyWKolejce == 7)
                {
                    Team1 = ListaDruzyn[6];
                    Team2 = ListaDruzyn[10];
                }
                else if (licznikMeczyWKolejce == 8)
                {
                    Team1 = ListaDruzyn[7];
                    Team2 = ListaDruzyn[11];
                }
                else if (licznikMeczyWKolejce == 9)
                {
                    Team1 = ListaDruzyn[8];
                    Team2 = ListaDruzyn[12];
                }
                else if (licznikMeczyWKolejce == 10)
                {
                    Team1 = ListaDruzyn[9];
                    Team2 = ListaDruzyn[13];
                    licznikKolejek++;
                    licznikMeczyWKolejce = 0;
                }
                licznikMeczyWKolejce++;
            }
        }// 5
        private void SymulacjaMeczu()
        {
            roznicaAttDef = Team1.AttOvr - Team2.DefOvr;
            roznicaDefAtt = Team2.AttOvr - Team1.DefOvr;
            roznicaMid = Team1.MidOvr - Team2.MidOvr;
            lock (syncLock)
            {
                if (roznicaAttDef >= 10) // Atak pierwszego Team'u jest DUŻO lepszy od obrony Team'u drugiego
                {
                    if (roznicaDefAtt >= 10) // Atak drugiego Team'u jest DUŻO lepszy od obrony Team'u pierwszego
                    {
                        if (roznicaMid >= 10) // Pomoc pierwszego zespołu Team'u jest DUŻO lepszy od pomocy Team'u drugiego
                        {
                            goleTeam1 = rand.Next(1, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10) // Pomoc pierwszego zespołu Team'u jest lepszy od pomocy Team'u drugiego
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0) // Pomoc pierwszego zespołu Team'u jest gorsza od pomocy Team'u drugiego
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid < -10) // Pomoc pierwszego zespołu Team'u jest DUŻO gorsza od pomocy Team'u drugiego
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(1, 4);
                        }
                    }
                    else if (roznicaDefAtt >= 0 && roznicaDefAtt < 10) // Atak drugiego Team'u jest lepszy od obrony Team'u pierwszego
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(1, 4);
                            goleTeam2 = rand.Next(0, 3);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 3);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(1, 4);
                        }
                    }
                    else if (roznicaDefAtt >= -10 && roznicaDefAtt < 0) // Atak drugiego Team'u jest słabszy od obrony Team'u pierwszego
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(1, 5);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 3);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 3);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 3);
                        }
                    }
                    else if (roznicaDefAtt < -10) // Atak drugiego Team'u jest DUŻO słabszy od obrony Team'u pierwszego
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(0, 5);
                            goleTeam2 = rand.Next(0, 3);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 3);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 3);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                    }
                }
                else if (roznicaAttDef >= 0 && roznicaAttDef < 10) // Atak Team'u pierwszego jest lepszy od obrony Team'u drugiego
                {
                    if (roznicaDefAtt >= 10)
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(0, 5);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 5);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 5);
                        }
                    }
                    else if (roznicaDefAtt >= 0 && roznicaDefAtt < 10)
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(1, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(1, 4);
                        }
                    }
                    else if (roznicaDefAtt >= -10 && roznicaDefAtt < 0)
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(1, 5);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 5);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 5);
                        }
                    }
                    else if (roznicaDefAtt < -10)
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(0, 5);
                            goleTeam2 = rand.Next(0, 3);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 5);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(1, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                    }
                }
                else if (roznicaAttDef >= -10 && roznicaAttDef < 0) // Atak Team'u pierwszego jest gorszy od obrony Team'u drugiego
                {
                    if (roznicaDefAtt >= 10)
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(1, 4);
                            goleTeam2 = rand.Next(1, 4);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(1, 4);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(1, 5);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(1, 5);
                        }
                    }
                    else if (roznicaDefAtt >= 0 && roznicaDefAtt < 10)
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(0, 5);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 5);
                            goleTeam2 = rand.Next(0, 5);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 5);
                        }
                    }
                    else if (roznicaDefAtt >= -10 && roznicaDefAtt < 0)
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 3);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 3);
                            goleTeam2 = rand.Next(0, 4);
                        }
                    }
                    else if (roznicaDefAtt < -10)
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(0, 5);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 5);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                    }
                }
                else if (roznicaAttDef < -10) // Atak Team'u pierwszego jest DUŻO gorszy od obrony Team'u drugiego
                {
                    if (roznicaDefAtt >= 10)
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 5);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(1, 5);
                        }
                    }
                    else if (roznicaDefAtt >= 0 && roznicaDefAtt < 10)
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 3);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 3);
                            goleTeam2 = rand.Next(0, 5);
                        }
                    }
                    else if (roznicaDefAtt >= -10 && roznicaDefAtt < 0)
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(0, 5);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 5);
                        }
                    }
                    else if (roznicaDefAtt < -10)
                    {
                        if (roznicaMid >= 10)
                        {
                            goleTeam1 = rand.Next(0, 5);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= 0 && roznicaMid < 10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid >= -10 && roznicaMid < 0)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 4);
                        }
                        else if (roznicaMid < -10)
                        {
                            goleTeam1 = rand.Next(0, 4);
                            goleTeam2 = rand.Next(0, 5);
                        }
                    }
                }
            }
            //---------------------------------------------------------
            WyswietlanieWyniku();
        }
        private void WyswietlanieWyniku()
        {
            if (goleTeam1 > goleTeam2)
            {
                pktyTeam1 = 3;
                pktyTeam2 = 0;
            }
            else if (goleTeam1 < goleTeam2)
            {
                pktyTeam1 = 0;
                pktyTeam2 = 3;
            }
            else if (goleTeam1 == goleTeam2)
            {
                pktyTeam1 = 1;
                pktyTeam2 = 1;
            }
            DruzynaPunkty z = new DruzynaPunkty(Team1.Nazwa, pktyTeam1);
            ListaDruzynaPunkty.Add(z);
            DruzynaPunkty z2 = new DruzynaPunkty(Team2.Nazwa, pktyTeam2);
            ListaDruzynaPunkty.Add(z2);
            Wynik = goleTeam1.ToString() + " : " + goleTeam2.ToString();
            ListaWynikow.Add(Wynik);
        }
        private void SymulacjaKolejki()
        {
            for (int i = 0; i < 10; i++)
            {
                PoznajRywali();
                SymulacjaMeczu();
            }
        }

    }
}
