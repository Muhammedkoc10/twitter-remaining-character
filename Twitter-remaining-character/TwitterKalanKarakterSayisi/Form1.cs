using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterKalanKarakterSayisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtGirileMetin.MaxLength = 450;
            lblKarakter.Text = txtGirileMetin.MaxLength.ToString();

        }

        private void txtGirileMetin_TextChanged(object sender, EventArgs e)
        {
            int KacKarakterVar = txtGirileMetin.TextLength;
            int kalanKarakter = txtGirileMetin.MaxLength - KacKarakterVar;
            lblKarakter.Text = kalanKarakter .ToString();

            if (kalanKarakter <=20)
            {
                lblKarakter.ForeColor = Color.Red;
                lblKarakter.Font = new Font(lblKarakter.Font,FontStyle.Bold);
            }
            else
            {
                lblKarakter.ForeColor = Color.Black;
                lblKarakter.Font = new Font(lblKarakter.Font, FontStyle.Regular);
            }
            
            if (KacKarakterVar == 450)
            {
                MessageBox.Show("Maximum sınıra ulaştınız");
            }
        }
    }
}
