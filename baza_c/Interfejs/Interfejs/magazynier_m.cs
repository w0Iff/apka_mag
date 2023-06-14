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
    }
}