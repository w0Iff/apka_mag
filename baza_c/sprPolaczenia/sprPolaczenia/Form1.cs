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
    public partial class glmenu : Form
    {
        Data.polaczenie con = new Data.polaczenie();
        public glmenu()
        {
            InitializeComponent();
            kntrOK.Visible = false;
            kntrERR.Visible = false;
        }

        private Timer connTimer;

public magazynier_m()
{
    InitializeComponent();
    connTimer = new Timer();
    connTimer.Interval = 5000; // check every 5 seconds
    connTimer.Tick += new EventHandler(connTimer_Tick);
    connTimer.Start();
}

private void connTimer_Tick(object sender, EventArgs e)
{
    if (!Data.polaczenie.connCheck())
    {
        // show error message and disable buttons
        MessageBox.Show("Connection lost!");
        btn_pozycja.Enabled = false;
        btn_usunpoz.Enabled = false;
        btn_aktm.Enabled = false;
    }
    else
    {
        // enable buttons
        btn_pozycja.Enabled = true;
        btn_usunpoz.Enabled = true;
        btn_aktm.Enabled = true;
    }
}
    }
}
