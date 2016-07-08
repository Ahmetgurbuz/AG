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



namespace CrmProjesi
{
    public partial class iliski : Form
    {
        public iliski()
        {
            InitializeComponent();
        }

        private void goster_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection("server=,; Initial Catalog=Crm; Integrated Security=SSPI");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select musteribilgileri.Musteriad,musteribilgileri.MusteriSoyad,urunbilgiler.urunadi  from  (musteribilgileri 

        }
    }
}
