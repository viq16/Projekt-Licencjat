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
        public OknoZarzadzania3()
        {
            InitializeComponent();
        }
        //---------------------------------
        public void ZmienNazwe2(String nazwa)
        {
            label2.Text = nazwa;
        }
        //---------------------------------
    }
}
