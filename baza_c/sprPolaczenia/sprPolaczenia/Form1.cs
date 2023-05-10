using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprPolaczenia
{
    public partial class Form1 : Form
    {
        Dane.polaczenie con = new Dane.polaczenie();
        public Form1()
        {
            InitializeComponent();
            kntrOK.Visible = false;
            kntrERR.Visible = false;
        }

        private void kntrSpr_Click(object sender, EventArgs e)
        {
            try
            {
                Dane.polaczenie.dataSource();
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
    }
}
