using MySql.Data.MySqlClient;
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
            foreach (Control control in Controls)
            {
                if (control is Button && control != kntrSpr)
                {
                    control.Enabled = false;
                }
            }
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
            try
            {
                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        control.Enabled = true;
                    }
                }
                MySqlConnection con = Data.polaczenie.dataSource();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Update UserTab set Nazwa=@Nazwa, DostepnaIlosc=@DostepnaIlosc, CenaZaSztuke=@CenaZaSztuke where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Nazwa", textBox2.Text);
                cmd.Parameters.AddWithValue("@DostepnaIlosc", double.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@CenaZaSztuke", double.Parse(textBox4.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Pomyślnie Zaktualizowano!");
            }
            catch (Exception ex)
            {
                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        control.Enabled = false;
                    }
                }
                MessageBox.Show("Error: " + ex.Message);
                this.Hide();
                sprzedawca_m form = new sprzedawca_m();
                form.FormClosed += (s, args) => this.Close();
                form.ShowDialog();
            }
        }

        private void kntrSpr_Click(object sender, EventArgs e)
        {
            try
            {
                Data.polaczenie.dataSource();
                con.connOpen();
                kntrOK.Visible = true;
                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        control.Enabled = true;
                    }
                }
                kntrERR.Visible = false;
                con.connClose();
            }
            catch (Exception)
            {
                kntrERR.Visible = true;
                kntrOK.Visible = false;
                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        control.Enabled = false;
                    }
                }
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
            try
            {
                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        control.Enabled = true;
                    }
                }
                MySqlConnection con = Data.polaczenie.dataSource();
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from UserTab", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSprzedawca.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                foreach (Control control in Controls)
                {
                    if (control is Button)
                    {
                        control.Enabled = false;
                    }
                }
                MessageBox.Show("Error: " + ex.Message);
                this.Hide();
                sprzedawca_m form = new sprzedawca_m();
                form.FormClosed += (s, args) => this.Close();
                form.ShowDialog();
            }
        }
    }
}
