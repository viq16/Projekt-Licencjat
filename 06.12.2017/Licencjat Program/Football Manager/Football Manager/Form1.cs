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
        /*
        public delegate void wyslij(int i);
        public event wyslij wyslijT;
        */
        BazaDataContext BazaFM = new BazaDataContext();
        //-----------------------------


        OknoZarzadzania OknoTreningowe = new OknoZarzadzania(); // TRENING

        OknoZarzadzania2 OknoTaktyczne = new OknoZarzadzania2(); // TAKTYKA

        OknoZarzadzania3 OknoStatystyk = new OknoZarzadzania3(); // STATYSTYKI

        OknoZarzadzania4 OknoInformacyjne = new OknoZarzadzania4(); // INFORMACJE
      
        //List<ZawodnikK> ListaZawodnikowDruzyny = new List<ZawodnikK>();


        //-----------------------------
        /*
        private int idL;
        private String NazwiskoL;
        private int SkillOvrL;
        private String PozycjaL;
        private int DruzynaIdL;      
        */
        //-----------------------------
        public OknoGlowne()
        {
            InitializeComponent();

            flpPanelSterowania.Controls.Add(OknoTreningowe);
            flpPanelSterowania.Controls.Add(OknoTaktyczne);
            flpPanelSterowania.Controls.Add(OknoStatystyk);
            flpPanelSterowania.Controls.Add(OknoInformacyjne);

            flpPanelSterowania.Hide();

            bInformacje.Hide();
            bStatystyki.Hide();
            bOknaTreningowego.Hide();
            bZarzadzaniaZespolem.Hide();
            lWybraneNazwisko.Hide();

            bZatwierdz.Enabled = false;
        }

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
            bStatystyki.Show();
            bOknaTreningowego.Show();
            bZarzadzaniaZespolem.Show();
            lWybraneNazwisko.Show();

            /*
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
            

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(ListaZawodnikowDruzyny.ToArray());
            comboBox1.DisplayMember = "Nazwisko";
            */

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
            OknoTaktyczne.Hide();
            OknoStatystyk.Hide();
            OknoInformacyjne.Hide();
        }

        private void bZarzadzaniaZespolem_Click(object sender, EventArgs e)
        {
            OknoTaktyczne.Show();
            OknoTreningowe.Hide();
            OknoStatystyk.Hide();
            OknoInformacyjne.Hide();
        }

        private void bStatystyki_Click(object sender, EventArgs e)
        {
            OknoStatystyk.Show();
            OknoTreningowe.Hide();
            OknoTaktyczne.Hide();
            OknoInformacyjne.Hide();
        }

        private void bInformacje_Click(object sender, EventArgs e)
        {
            OknoInformacyjne.Show();
            OknoTreningowe.Hide();
            OknoTaktyczne.Hide();
            OknoStatystyk.Hide();
        }
        /*
private void PrzejmijDruzyne()
{
   wyslijT?.Invoke(IdWybranegoKlubu);
}
*/
    }
}
