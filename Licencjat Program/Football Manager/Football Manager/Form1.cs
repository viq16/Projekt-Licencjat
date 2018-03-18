using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Football_Manager
{
    public partial class OknoGlowne : Form
    {
        BazaDataContext BazaFM = new BazaDataContext();
        //-----------------------------
        OknoZarzadzania OknoTreningowe = new OknoZarzadzania(); // TRENING

        OknoZarzadzania2 OknoStatystyk = new OknoZarzadzania2(); // TAKTYKA

        OknoZarzadzania3 OknoTabeli = new OknoZarzadzania3(); // STATYSTYKI

        OknoZarzadzania4 OknoMeczowe = new OknoZarzadzania4(); // INFORMACJE

        public OknoGlowne()
        {
            InitializeComponent();
            //---------------------------------
            OknoTreningowe.wDruzyny += w_Druzyny;
            OknoTreningowe.wDruzynyNazwa += w_DruzynyNazwa;
            OknoTreningowe.wDruzynyNazwa += w_DruzynyNazwa2;
            OknoMeczowe.wyslijWyniki += wyslij_Wyniki;
            OknoMeczowe.dodajPunkty += dodaj_Punkty;

            //---------------------------------
            flpPanelSterowania.Controls.Add(OknoTreningowe);
            flpPanelSterowania.Controls.Add(OknoTabeli);
            flpPanelSterowania.Controls.Add(OknoStatystyk);
            flpPanelSterowania.Controls.Add(OknoMeczowe);

            flpPanelSterowania.Hide();

            bInformacje.Hide();
            bOknaTreningowego.Hide();
            bOknaZarzadzaniaZespolem.Hide();
            bStatystyki.Hide();
            lWybraneNazwisko.Hide();

            bZatwierdz.Enabled = false;
        }
        //---------------------------------
        private void dodaj_Punkty(List<DruzynaPunkty> d)
        {
            OknoTabeli.OtrzymajPunkty(d);
        }
        private void w_Druzyny(Druzyna d)
        {
            OknoStatystyk.ZmienNazwe(d.ToString());
        }
        private void wyslij_Wyniki(List<String> d)
        {
            OknoStatystyk.OtrzymajWyniki(d);
        }
        private void w_DruzynyNazwa(String d)
        {
            OknoMeczowe.ZmienNazwe2(d.ToString());
        }
        private void w_DruzynyNazwa2(String d)
        {
            OknoTabeli.ZmienNazwe2(d.ToString());
        }
        //---------------------------------
        private void bWybierz_Click(object sender, EventArgs e)
        {
            lWybraneNazwisko.Text = tbNazwiskoManagera.Text;

            if (rbManager1.Checked)
            {
                pbWybranegoAvatara.ImageLocation = @"C:\Users\Erazer\Desktop\Licencjat Program\Pliki graficzne\WKManager1.png";
            }
            else if (rbManager2.Checked)
            {
                pbWybranegoAvatara.ImageLocation = @"C:\Users\Erazer\Desktop\Licencjat Program\Pliki graficzne\WKManager2.png";
            }
            else if (rbManager3.Checked)
            {
                pbWybranegoAvatara.ImageLocation = @"C:\Users\Erazer\Desktop\Licencjat Program\Pliki graficzne\WKManager3.png";
            }

            pbManager1.Dispose();
            pbManager2.Dispose();
            pbManager3.Dispose();
            bZatwierdz.Dispose();
            tbNazwiskoManagera.Dispose();
            lTwojeN.Dispose();
            lWybierzSA.Dispose();
            rbManager1.Dispose();
            rbManager2.Dispose();
            rbManager3.Dispose();

            gbOknoAvatarow.Dispose();
            gbOknoInicjalizacji.Dispose();

            flpPanelSterowania.Show();
            bInformacje.Show();
            bOknaTreningowego.Show();
            bOknaZarzadzaniaZespolem.Show();
            bStatystyki.Show();
            lWybraneNazwisko.Show();
        } 

        private void cbListaDruzyn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZaladowanieDanych();
        }
        private void ZaladowanieDanych()
        {
            int NumerAvatara = 0;

            string NazwiskoManagera = tbNazwiskoManagera.Text as string;
            if(rbManager1.Checked)
            {
                NumerAvatara = 1;
            }
            else if(rbManager2.Checked)
            {
                NumerAvatara = 2;
            }
            else if(rbManager3.Checked)
            {
                NumerAvatara = 3;
            }

            if (NazwiskoManagera != null && NazwiskoManagera != "" && NumerAvatara != 0)
            {
                bZatwierdz.Enabled = true;
            }
        }

        private void rbManager1_CheckedChanged(object sender, EventArgs e)
        {
            ZaladowanieDanych();
        }
        private void rbManager2_CheckedChanged(object sender, EventArgs e)
        {
            ZaladowanieDanych();
        }
        private void rbManager3_CheckedChanged(object sender, EventArgs e)
        {
            ZaladowanieDanych();
        }

        private void tbNazwiskoManagera_TextChanged(object sender, EventArgs e)
        {
            ZaladowanieDanych();
        }

        private void bOknaTreningowego_Click(object sender, EventArgs e)
        {
            OknoTreningowe.Show();
            OknoTabeli.Hide();
            OknoStatystyk.Hide();
            OknoMeczowe.Hide();
        }

        private void bZarzadzaniaZespolem_Click(object sender, EventArgs e)
        {
            OknoTabeli.Show();
            OknoTreningowe.Hide();
            OknoStatystyk.Hide();
            OknoMeczowe.Hide();
        }

        private void bStatystyki_Click(object sender, EventArgs e)
        {
            OknoStatystyk.Show();
            OknoTreningowe.Hide();
            OknoTabeli.Hide();
            OknoMeczowe.Hide();
        }

        private void bInformacje_Click(object sender, EventArgs e)
        {
            OknoMeczowe.Show();
            OknoTreningowe.Hide();
            OknoTabeli.Hide();
            OknoStatystyk.Hide();
        }
    }
}
