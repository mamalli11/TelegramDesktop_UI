using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AppMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AppMaximum_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                NoChatSelectLbl.Location = new Point(500, 400);
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                NoChatSelectLbl.Location = new Point(133, 300);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            bunifuTransition1.Show(MenuPanel);
        }

        private void AppExit_MouseMove(object sender, MouseEventArgs e)
        {
            AppExit.BackColor = Color.FromArgb(224, 28, 21);
            AppExit.ForeColor = Color.White;
        }

        private void AppExit_MouseLeave(object sender, EventArgs e)
        {
            AppExit.BackColor = Color.FromArgb(58, 64, 71);
            AppExit.ForeColor = Color.FromArgb(134, 140, 145);
        }

        private void btnMenu_MouseMove(object sender, MouseEventArgs e)
        {
            btnMenu.ForeColor = Color.White;
        }

        private void btnMenu_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.ForeColor = Color.FromArgb(134, 140, 145);
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            bunifuTransition1.Hide(MenuPanel);
        }

        private void AppMinimize_MouseLeave(object sender, EventArgs e)
        {
            AppMinimize.BackColor = Color.FromArgb(58, 64, 71);
            AppMinimize.ForeColor = Color.FromArgb(134, 140, 145);
        }

        private void AppMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            AppMinimize.BackColor = Color.FromArgb(76, 83, 91);
            AppMinimize.ForeColor = Color.White;
        }

        private void AppMaximum_MouseLeave(object sender, EventArgs e)
        {
            AppMaximum.BackColor = Color.FromArgb(58, 64, 71);
            AppMaximum.ForeColor = Color.FromArgb(134, 140, 145);
        }

        private void AppMaximum_MouseMove(object sender, MouseEventArgs e)
        {
            AppMaximum.BackColor = Color.FromArgb(76, 83, 91);
            AppMaximum.ForeColor = Color.White;
        }

        private void ContentPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (MenuPanel.Visible == true)
            {
                bunifuTransition1.Hide(MenuPanel);
            }
        }

        private void btnNightMode_Click(object sender, EventArgs e)
        {
            if (TogSwitNightMode.Value == true)
            {
                TogSwitNightMode.Value = false;
            }
            else
            {
                TogSwitNightMode.Value = true;
            }
        }
    }
}