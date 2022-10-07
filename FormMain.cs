using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Manement_System
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

    

        private void ptnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ptnMix_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;

            }
        }

        private void ptnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ptnCollapse_Click(object sender, EventArgs e)
        {
            if (Panel_Navbar.Width == 220)
            {
                Panel_Navbar.Width = 50;
                Panel_Title.Visible = false;
                Panel_Title.Height = 172;
            }
            else
            {
                Panel_Navbar.Width = 220;
                Panel_Title.Visible = true;
                Panel_Title.Height = 172;

            }
        }
    }
}
