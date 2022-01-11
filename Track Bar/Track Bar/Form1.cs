using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Track_Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trckVolume_Scroll(object sender, EventArgs e)
        {
            String vrijednost = trckVolume.Value.ToString();
            txtIspis.Text = vrijednost;
        }
    }
}
