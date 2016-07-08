using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmProjesi
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void müşteriBilgiGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
             musteribilgigirisi m = new musteribilgigirisi();
 
            m.ShowDialog();


        }

        private void müşteriAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arama a = new Arama();
            a.ShowDialog();

        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void satışFiyatlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
                  




        }

        private void ürünBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunbilgileri u = new urunbilgileri();
            u.ShowDialog();

        }

        private void ürünAnalizToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
