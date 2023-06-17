using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfejs
{
    public partial class gl_menu : Form
    {
        public gl_menu()
        {
            InitializeComponent();
        }
  private void gl_menu_Load(object sender, EventArgs e)

        {

        }

        private void lbl_glnazwa_Click(object sender, EventArgs e)
        {

        }

        private void lbl_wersja_Click(object sender, EventArgs e)
        {

        }

        private void btn_sprzedawca_Click(object sender, EventArgs e)
        {
            sprzedawca_m form = new sprzedawca_m();
            form.ShowDialog();
        }

        private void btn_magazynier_Click(object sender, EventArgs e)
        {
            magazynier_m form = new magazynier_m();
            form.ShowDialog();
        }
    }
}
