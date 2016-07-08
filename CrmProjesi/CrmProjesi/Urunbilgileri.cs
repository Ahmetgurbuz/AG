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
    public partial class urunbilgileri : Form
    {
        public urunbilgileri()
        {
            InitializeComponent();
        }

        private void stok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm;Integrated Security=SSPI");

            SqlCommand cmd = new SqlCommand("Delete from urunbilgiler where urunid=@id", baglanti);

            cmd.Parameters.AddWithValue("@id",dgurunbilgileri.CurrentRow.Cells[0].Value);
     

            baglanti.Open();
            cmd.ExecuteNonQuery();
            griddoldur();






        }

        private void dgurunbilgileri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");
            baglanti.Open();
            SqlCommand cmd = new SqlCommand();


            cmd.Connection = baglanti;
            cmd.CommandText = "Insert into  urunbilgiler (urunadi,satisfiyati,alisfiyati,miktar) values ('" + txturunadi.Text + "','" + txtsatisfiyati.Text + "','" + txtalisfiyati.Text + "','" + txtmiktar.Text + "')";
            cmd.ExecuteNonQuery();
            griddoldur();


            baglanti.Close();


        }
        void griddoldur()
        {
            SqlConnection con = new SqlConnection("server=.; Initial Catalog=Crm; Integrated Security=SSPI");

            SqlDataAdapter da = new SqlDataAdapter("Select *from urunbilgiler", con);
            DataSet ds = new DataSet();
            con.Open();
            da.Fill(ds, "urunbilgiler");

            dgurunbilgileri.DataSource = ds.Tables["urunbilgiler"];
            con.Close();







        }

        private void urunbilgileri_Load(object sender, EventArgs e)
        {

            griddoldur();
        }

    }
}


