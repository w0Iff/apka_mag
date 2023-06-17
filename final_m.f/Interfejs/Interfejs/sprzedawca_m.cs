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
    public partial class sprzedawca_m : Form
    {
        Data.polaczenie con = new Data.polaczenie();
        public sprzedawca_m()
        {
            InitializeComponent();
            kntrOK.Visible = false;
            kntrERR.Visible = false;
        }

        private void sprzedawca_m_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_akt_sprz_Click(object sender, EventArgs e)
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

        private void kntrERR_Click(object sender, EventArgs e)
        {

        }

        private void kntrOK_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSprzedawca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BazaTestowa;Integrated Security=True;Pooling=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserTab", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewSprzedawca.DataSource = dt;
        }
    }
}
