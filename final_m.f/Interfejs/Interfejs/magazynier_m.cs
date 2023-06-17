using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfejs
{
    public partial class magazynier_m : Form
    {
        Data.polaczenie con = new Data.polaczenie();
        public magazynier_m()
        {
            InitializeComponent();
            kntrOK.Visible = false;
            kntrERR.Visible = false;
        }

        private void kntrSpr_Click(object sender, EventArgs e)
        {
            try
            {
                Data.polaczenie.dataSource();
                con.connOpen();
                kntrOK.Visible = true;
                kntrERR.Visible = false;
                con.connClose();
            }
            catch (Exception)
            {
                kntrERR.Visible = true;
                kntrOK.Visible = false;
                con.connClose();
            }
            finally
            {
                con.connClose();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_aktm_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BazaTestowa;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UserTab set Nazwa=@Nazwa, DostepnaIlosc=@DostepnaIlosc, CenaZaSztuke=@CenaZaSztuke where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nazwa", textBox2.Text);
            cmd.Parameters.AddWithValue("DostepnaIlosc", double.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("CenaZaSztuke", double.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Pomyślnie Zaktualizowano!");
        }

        private void btn_pozycja_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BazaTestowa;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into UserTab values (@ID, @Nazwa, @DostepnaIlosc, @CenaZaSztuke)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nazwa", textBox2.Text);
            cmd.Parameters.AddWithValue("@DostepnaIlosc", double.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("CenaZaSztuke", double.Parse(textBox4.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Pomyślnie Zapisano!");
        }

        private void btn_usunpoz_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BazaTestowa;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete UserTab where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Pomyślnie usunięto!");
        }

        private void btn_szukaj_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BazaTestowa;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserTab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_wyszukiwanie_mag_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BazaTestowa;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserTab where ID=@ID", con);
            cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}