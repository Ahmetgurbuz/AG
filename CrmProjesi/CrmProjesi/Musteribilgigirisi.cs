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
    public partial class musteribilgigirisi : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;



        void griddoldur()
        {
            con = new SqlConnection("server=.; Initial Catalog=Crm;Integrated Security=SSPI");
            da = new SqlDataAdapter("Select *From musteribilgileri", con);
            ds = new DataSet();
            con.Open();
           
            da.Fill(ds, "musteribilgileri");
          
            dgmusteri.DataSource = ds.Tables["musteribilgileri"];
            
            con.Close();
        } 

        public musteribilgigirisi()
        {
            InitializeComponent();
        }

        private void Musteribilgileri_Load(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {

            con = new SqlConnection("server=.; Initial Catalog=Crm;Integrated Security=SSPI");
            cmd = new SqlCommand();
            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "insert into musteribilgileri (Musteritcno,Musteriad,MusteriSoyad,Musteritelno,Musteriadres) values ('" + txttcno.Text + "','" + txtad.Text + "','" + txtSoyad.Text + "','" + txttel.Text + "','" + rtxtadres.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();





        }

        private void rtxtadres_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgmusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {


            try
            {

                SqlCommand cmd = new SqlCommand("delete from musteribilgileri where Musteriid=@id", con);

                cmd.Parameters.AddWithValue("@id", dgmusteri.CurrentRow.Cells[0].Value);

                con.Open(); //Bağlantıyı açtık
                cmd.ExecuteNonQuery();//Geriye değer dönmediği için NonQuery kullanıyoruz.......
               griddoldur();

          
             
                con.Close();



            }
            catch
            {
                MessageBox.Show("hata");

            }

          
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "Update musteribilgileri Set  Musteriad=@ad,MusteriSoyad=@soyad,Musteritelno=@telno,Musteriadres=@adres Where Musteritcno=@tc";
            cmd= new SqlCommand(sorgu, con );
            
            cmd.Parameters.AddWithValue("@tc",txttcno.Text);
            cmd.Parameters.AddWithValue("@ad", txtad.Text);
           cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@telno",txttel.Text);
            cmd.Parameters.AddWithValue("@adres", rtxtadres.Text);
        
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();






           
        }
    }
} 
