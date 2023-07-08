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
    public partial class magazynier_m : Form
    {
        Data.polaczenie con = new Data.polaczenie();
        public magazynier_m()
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

        private void kntrSpr_Click(object sender, EventArgs e)
        {
            try
            {
                Data.polaczenie.dataSource();
                con.connOpen();
                kntrOK.Visible = true;
                foreach (Control control in Controls)
                {
                    if (control is Button && control != kntrSpr)
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
                    if (control is Button && control != kntrSpr)
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


        private void label1_Click(object sender, EventArgs e)
        {
            kntrERR.Visible = true;
            kntrOK.Visible = false;
            con.connClose();
        }

        private void btn_aktm_Click(object sender, EventArgs e)
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
                magazynier_m form = new magazynier_m();
                form.FormClosed += (s, args) => this.Close();
                form.ShowDialog();
            }
        }

        private void btn_pozycja_Click(object sender, EventArgs e)
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
                MySqlCommand cmd = new MySqlCommand("Insert into UserTab values (@ID, @Nazwa, @DostepnaIlosc, @CenaZaSztuke)", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@Nazwa", textBox2.Text);
                cmd.Parameters.AddWithValue("@DostepnaIlosc", double.Parse(textBox3.Text));
                cmd.Parameters.AddWithValue("@CenaZaSztuke", double.Parse(textBox4.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Pomyślnie Zapisano!");
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
                magazynier_m form = new magazynier_m();
                form.FormClosed += (s, args) => this.Close();
                form.ShowDialog();
            }
        }

        private void btn_usunpoz_Click(object sender, EventArgs e)
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
                MySqlCommand cmd = new MySqlCommand("Delete from UserTab where ID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Pomyślnie usunięto!");
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
                magazynier_m form = new magazynier_m();
                form.FormClosed += (s, args) => this.Close();
                form.ShowDialog();
            }
        }

        private void btn_szukaj_Click(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;
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
                magazynier_m form = new magazynier_m();
                form.FormClosed += (s, args) => this.Close();
                form.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_wyszukiwanie_mag_Click(object sender, EventArgs e)
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
                MySqlCommand cmd = new MySqlCommand("Select * from UserTab where ID=@ID", con);
                cmd.Parameters.AddWithValue("ID", int.Parse(textBox1.Text));
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
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
                magazynier_m form = new magazynier_m();
                form.FormClosed += (s, args) => this.Close();
                form.ShowDialog();
            }
        }

        private void kntrERR_Click(object sender, EventArgs e)
        {

        }
    }
}