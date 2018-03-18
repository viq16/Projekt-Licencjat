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
    
    public partial class OknoZarzadzania : UserControl
    { 
        List<ZawodnikK> ListaZawodnikowDruzyny = new List<ZawodnikK>();
        Druzyna WybranyTeam;
        String NazwaDruzyny;
        //---------------------------------
        public delegate void delegat1(Druzyna d);
        public event delegat1 wDruzyny;
        public delegate void delegat2(String d);
        public event delegat2 wDruzynyNazwa;
        //---------------------------------
        Graphics grafika;
        BazaDataContext BazaFM = new BazaDataContext();
        public OknoZarzadzania()
        {
            InitializeComponent();
            pbTablicaTaktyczna.Image = new Bitmap(pbTablicaTaktyczna.Width, pbTablicaTaktyczna.Height);
            grafika = Graphics.FromImage(pbTablicaTaktyczna.Image);
            grafika.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cbListaDruzyn.DisplayMember = "Nazwa";
            bZatwierdzDruzyne.Enabled = false;
            OdrysujUstawienieDomyslne();
            pbTablicaTaktyczna.Hide();
            lTrening.Hide();
            gbFormacji.Hide();
            gbPilkarze.Hide();
            cbListaZawodnikow.Hide();
            pTlaGb.Hide();
            Wczytaj();        
        }
        private void Wczytaj()
        {
            cbListaDruzyn.Items.Clear();
            cbListaDruzyn.Items.AddRange(BazaFM.Druzynas.ToArray());
        }

        private void bZatwierdzDruzyne_Click(object sender, EventArgs e)
        {
            WybranyTeam = cbListaDruzyn.SelectedItem as Druzyna;
            NazwaDruzyny = WybranyTeam.Nazwa;
            lTrening.Show();
            gbFormacji.Show();
            pbTablicaTaktyczna.Show();
            gbPilkarze.Show();
            cbListaZawodnikow.Show();
            pTlaGb.Show();
            //---------------------------------
            wDruzyny?.Invoke(WybranyTeam as Druzyna);
            wDruzynyNazwa?.Invoke(NazwaDruzyny as String);
            //---------------------------------
            //------------------
            ZapisZawodnikowDoListy();
            ZaładujZawodnikow();
            for(int i=0; i<17; i++)
            {
                WypisZawodnikowZListy();
            }
            //------------------
            lTwojaD.Dispose();
            cbListaDruzyn.Dispose();
            bZatwierdzDruzyne.Dispose();
        }
        private void CzyscTablice()
        {
            //pbTablicaTaktyczna.ImageLocation = @"C:\Users\Erazer\Desktop\Licencjat Program\Pliki graficzne\Tablica Taktyczna.png;
            grafika.Clear(Color.Transparent);
            pbTablicaTaktyczna.Refresh();
        }
        private void OdrysujUstawienieDomyslne()
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.White), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 100, 122, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 100, 182, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 120, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 120, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 230, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 240, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 240, 234, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 400, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 390, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 390, 234, 30, 30);

            pbTablicaTaktyczna.Refresh();
        }
        private void b433_Click(object sender, EventArgs e) // FORMACJA 4-3-3
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.White), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 100, 122, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 100, 182, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 120, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 120, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 230, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 240, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 240, 234, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 400, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 390, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 390, 234, 30, 30);

            pbTablicaTaktyczna.Refresh();
        }

        private void b442_Click(object sender, EventArgs e) // FORMACJA 4-4-2
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.White), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 100, 122, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 100, 182, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 120, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 120, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 240, 122, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 240, 182, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 275, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 275, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 390, 120, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 390, 184, 30, 30);

            pbTablicaTaktyczna.Refresh();
        }

        private void b352_Click(object sender, EventArgs e) // FORMACJA 3-5-2
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.White), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 100, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 120, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 120, 234, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 230, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 240, 90, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 240, 214, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 260, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 260, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 390, 120, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 390, 184, 30, 30);

            pbTablicaTaktyczna.Refresh();
        }

        private void b523_Click(object sender, EventArgs e) // FORMACJA 5-2-3
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.White), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 100, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 110, 90, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 110, 214, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 130, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 130, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 240, 120, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 240, 184, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 400, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 390, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 390, 234, 30, 30);

            pbTablicaTaktyczna.Refresh();
        }

        private void b532_Click(object sender, EventArgs e) // FORMACJA 5-3-2
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.White), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 100, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 110, 90, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 110, 214, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 130, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 130, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 230, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 240, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 240, 234, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 390, 120, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 390, 184, 30, 30);

            pbTablicaTaktyczna.Refresh();
        }

        private void b343_Click(object sender, EventArgs e) // FORMACJA 3-4-3
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.White), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 100, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 120, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 120, 234, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 240, 122, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 240, 182, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 275, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 275, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.White), 400, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 390, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.White), 390, 234, 30, 30);


            pbTablicaTaktyczna.Refresh();
        }
        private void ZapisZawodnikowDoListy()
        {
            int idL;
            String NazwiskoL;
            int SkillOvrL;
            String PozycjaL;
            int DruzynaIdL;

            foreach (Zawodnik zz in WybranyTeam.Zawodniks)
            {
                idL = zz.Id;
                NazwiskoL = zz.Nazwisko;
                SkillOvrL = zz.SkillOvr;
                PozycjaL = zz.Pozycja;
                DruzynaIdL = zz.DruzynaId;

                ZawodnikK z = new ZawodnikK(idL, NazwiskoL, SkillOvrL, PozycjaL, DruzynaIdL);
                ListaZawodnikowDruzyny.Add(z);
            }
        }
        private void WypisZawodnikowZListy()
        {
            int licznik = 0;
            foreach (ZawodnikK zz in ListaZawodnikowDruzyny)
            {
                if (licznik == 0)
                {
                    label1.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 1)
                {
                    label2.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 2)
                {
                    label3.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 3)
                {
                    label4.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 4)
                {
                    label5.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 5)
                {
                    label6.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 6)
                {
                    label7.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 7)
                {
                    label8.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 8)
                {
                    label9.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 9)
                {
                    label10.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 10)
                {
                    label11.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 11)
                {
                    label12.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 12)
                {
                    label13.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 13)
                {
                    label14.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 14)
                {
                    label15.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 15)
                {
                    label16.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 16)
                {
                    label17.Text = zz.Nazwisko;
                    licznik++;
                }
                else if (licznik == 17)
                {
                    label18.Text = zz.Nazwisko;
                    licznik++;
                    break;
                }

            }
        }
        private void ZaładujZawodnikow()
        {
            cbListaZawodnikow.Items.Clear();
            cbListaZawodnikow.Items.AddRange(ListaZawodnikowDruzyny.ToArray());
            cbListaZawodnikow.DisplayMember = "Nazwisko";
        }

        private void cbListaDruzyn_SelectedIndexChanged(object sender, EventArgs e)
        {
            bZatwierdzDruzyne.Enabled = true;
        }
    }
}
