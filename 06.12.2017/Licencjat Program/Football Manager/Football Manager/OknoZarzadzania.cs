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
        private int idL;
        private String NazwiskoL;
        private int SkillOvrL;
        private String PozycjaL;
        private int DruzynaIdL;

        List<ZawodnikK> ListaZawodnikowDruzyny = new List<ZawodnikK>();

        Druzyna WybranyTeam;
        Graphics grafika;
        BazaDataContext BazaFM = new BazaDataContext();
        public OknoZarzadzania()
        {
            InitializeComponent();
            pbTablicaTaktyczna.Image = new Bitmap(pbTablicaTaktyczna.Width, pbTablicaTaktyczna.Height);
            grafika = Graphics.FromImage(pbTablicaTaktyczna.Image);
            grafika.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cbListaDruzyn.DisplayMember = "Nazwa";
            pbTablicaTaktyczna.Hide();
            lTrening.Hide();
            gbFormacji.Hide();
            gbPilkarze.Hide();
            lBramkarze.Hide();
            lObroncy.Hide();
            lPomocnicy.Hide();
            lNapastnicy.Hide();
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
            lTrening.Show();
            gbFormacji.Show();
            pbTablicaTaktyczna.Show();
            gbPilkarze.Show();
            lBramkarze.Show();
            lObroncy.Show();
            lPomocnicy.Show();
            lNapastnicy.Show();
            pbTablicaTaktyczna.Refresh();
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
        private void b433_Click(object sender, EventArgs e) // FORMACJA 4-3-3
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 100, 122, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 100, 182, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 120, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 120, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 230, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 240, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 240, 234, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 400, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 390, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 390, 234, 30, 30);

            pbTablicaTaktyczna.Refresh();
        }

        private void b442_Click(object sender, EventArgs e) // FORMACJA 4-4-2
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 100, 122, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 100, 182, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 120, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 120, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 240, 122, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 240, 182, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 275, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 275, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 390, 120, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 390, 184, 30, 30);

            pbTablicaTaktyczna.Refresh();
        }

        private void b352_Click(object sender, EventArgs e) // FORMACJA 3-5-2
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 100, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 120, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 120, 234, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 230, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 240, 90, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 240, 214, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 260, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 260, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 390, 120, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 390, 184, 30, 30);

            pbTablicaTaktyczna.Refresh();
        }

        private void b523_Click(object sender, EventArgs e) // FORMACJA 5-2-3
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 100, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 110, 90, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 110, 214, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 130, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 130, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 240, 120, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 240, 184, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 400, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 390, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 390, 234, 30, 30);

            pbTablicaTaktyczna.Refresh();
        }

        private void b532_Click(object sender, EventArgs e) // FORMACJA 5-3-2
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 100, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 110, 90, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 110, 214, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 130, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 130, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 230, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 240, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 240, 234, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 390, 120, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 390, 184, 30, 30);

            pbTablicaTaktyczna.Refresh();
        }

        private void b343_Click(object sender, EventArgs e) // FORMACJA 3-4-3
        {
            CzyscTablice();
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 10, 152, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 100, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 120, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 120, 234, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 240, 122, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 240, 182, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 275, 40, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 275, 264, 30, 30);

            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 400, 152, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 390, 70, 30, 30);
            grafika.FillEllipse(new SolidBrush(Color.DarkRed), 390, 234, 30, 30);


            pbTablicaTaktyczna.Refresh();
        }
        private void ZapisZawodnikowDoListy()
        {
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
            foreach (ZawodnikK zz in ListaZawodnikowDruzyny)
            {

                ListaZawodnikowDruzyny.Remove(zz);
            }
        }
    }
}
