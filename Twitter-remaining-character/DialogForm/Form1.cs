using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dialog form olarak açılan formlar kapatılmadan, arkadaki formlara ulaşılamaz!
            new Form().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Normal Form olarak açılan formlar, diğer açık olan formları engellemez!
            new Form().Show(); // İlgili controlü (burada formu) kullanıcıya gösterir.
            MessageBox.Show("Merhaba Dünya",  "Uyarı!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); // Dialog form olarak açılır. İşlem tamamlanmadan arkadaki formlara ulaşıma izin verilmez.
        }
    }
}
