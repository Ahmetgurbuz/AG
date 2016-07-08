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
    public partial class Arama : Form
    {
        public Arama()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*void griddoldur()
        {
           SqlConnection  con = new SqlConnection("server=.; Initial Catalog=Crm;Integrated Security=SSPI");
         SqlDataAdapter da = new SqlDataAdapter("Select *From musteribilgileri", con);
           DataSet ds = new DataSet();
            con.Open();

            da.Fill(ds, "musteribilgileri");
dataGridView1.DataSource = ds.Tables["musteribilgileri"];

            con.Close();
        }

         */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {






        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Arama_Load(object sender, EventArgs e)
        {
        }

        private void btnara_Click(object sender, EventArgs e)
        {




            if (textBox1.Text == "         ")
            {
                SqlConnection baglanti = new SqlConnection("server=,; Initial Catalog=Crm; Integrated Security=SSPI");
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select *From musteribilgileri", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "musteribilgileri");
                dataGridView1.DataSource = ds.Tables["musteribilgileri"];

                baglanti.Close();


            }

            else if (checkBox1.Checked == true)
            {


                SqlConnection baglanti = new SqlConnection("server=.; Initial Catalog=Crm;Integrated Security=SSPI");
                baglanti.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select *from musteribilgileri where Musteriad  like  '" + textBox1.Text + "%'", baglanti);
                DataSet ds = new DataSet();

                da.Fill(ds, "musteribilgileri");
                this.dataGridView1.DataSource = ds.Tables[0];




                baglanti.Close();


            }
            else if (checkBox2.Checked == true)
            {
                SqlConnection baglanti = new SqlConnection("server=.;  Initial Catalog=Crm; Integrated Security=SSPI");
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select *from musteribilgileri where MusteriSoyad like '" + textBox1.Text + "%'", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds, "musteribilgileri");
                this.dataGridView1.DataSource = ds.Tables[0];




            }
            else if (checkBox3.Checked == true)
            {


                SqlConnection baglanti = new SqlConnection("server=.;  Initial Catalog=Crm; Integrated Security=SSPI");
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select *from musteribilgileri where Musteritcno like '" + textBox1.Text + "%'", baglanti);
                DataSet ds = new DataSet();

                da.Fill(ds, "musteribilgileri");
                this.dataGridView1.DataSource = ds.Tables[0];

            }
        }
    }
}