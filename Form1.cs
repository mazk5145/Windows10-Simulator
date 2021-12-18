using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcsim
{
    public partial class Form1 : Form
    {
        private bool isCollapsedmenu;
        private bool isCollapsednotif;
        public Form1()
        {
            InitializeComponent();
        }

        private void datetime_Tick(object sender, EventArgs e)
        {
            datetimeset();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!isCollapsednotif)
            {
                notifmenu.Start();
            }


            winmenu.Start();
            datetimeset();
        }

        private void bottompanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!isCollapsedmenu)
            {
                winmenu.Start();
            }
            if (!isCollapsednotif)
            {
                notifmenu.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbctrl.Size = new Size(671, 408);
            //notifypanelclockworker.RunWorkerAsync();
            datetimeset();
            initnotifycalander();
        }

        public void initnotifycalander()
        {

        }

        public void datetimeset()
        {
            string year = String.Format("{0:H:mm}", DateTime.Now);

            datemd.Text = String.Format("{0:d/M/yyyy}", DateTime.Now);
            datett.Text = String.Format("{0:H:mm}", DateTime.Now);
            sdmytxt.Text = String.Format("{0:dddd d: MMMM yyyy}", DateTime.Now);
        }

        public void datetimenotifybar()
        {
            notifypaneltime.Text = String.Format("{0:H:mm:ss}", DateTime.Now);
        }

        private void winmenu_Tick(object sender, EventArgs e)
        {
            if (isCollapsedmenu)
            {
                windowsmenu.Visible = true;
                windowsmenu.Height += 10;
                if (windowsmenu.Size == windowsmenu.MaximumSize)
                {
                    winmenu.Stop();
                    //settingmenu.FillColor = Color.White;
                    isCollapsedmenu = false;
                }
            }
            else
            {
                windowsmenu.Height -= 10;
                if (windowsmenu.Size == windowsmenu.MinimumSize)
                {
                    windowsmenu.Visible = false;
                    winmenu.Stop();
                    //settingmenu.FillColor = Color.Transparent;
                    isCollapsedmenu = true;
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (!isCollapsedmenu)
            {
                winmenu.Start();
            }
            if (!isCollapsednotif)
            {
                notifmenu.Start();
            }
        }

        private void edge_Click(object sender, EventArgs e)
        {
            if (!isCollapsedmenu)
            {
                winmenu.Start();
            }
            if (!isCollapsednotif)
            {
                notifmenu.Start();
            }
        }

        private void mic_Click(object sender, EventArgs e)
        {
            if (!isCollapsedmenu)
            {
                winmenu.Start();
            }
            if (!isCollapsednotif)
            {
                notifmenu.Start();
            }
        }

        private void bottompanel_Click(object sender, EventArgs e)
        {
            if (!isCollapsedmenu)
            {
                winmenu.Start();
            }
            if (!isCollapsednotif)
            {
                notifmenu.Start();
            }

        }

        private void notifbtn_Click(object sender, EventArgs e)
        {
            if (!isCollapsedmenu)
            {
                winmenu.Start();
            }
            notifmenu.Start();
        }

        private void notifmenu_Tick(object sender, EventArgs e)
        {
            if (isCollapsednotif)
            {
                notifpanel.Visible = true;
                notifpanel.Height += 10;
                if (notifpanel.Size == notifpanel.MaximumSize)
                {
                    notifmenu.Stop();
                    //settingmenu.FillColor = Color.White;
                    isCollapsednotif = false;
                }
            }
            else
            {
                notifpanel.Height -= 10;
                if (notifpanel.Size == notifpanel.MinimumSize)
                {
                    notifpanel.Visible = false;
                    notifmenu.Stop();
                    //settingmenu.FillColor = Color.Transparent;
                    isCollapsednotif = true;
                }
            }
        }

        private void nnnnn_Tick(object sender, EventArgs e)
        {
            datetimenotifybar();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void chromebtn_Click(object sender, EventArgs e)
        {
            tbctrl.Visible = true;
            tbctrl.SelectedTab = chromewindow;
        }

        private void discordbtn_Click(object sender, EventArgs e)
        {
            tbctrl.Visible = true;
            tbctrl.SelectedTab = discordwindow;
        }

        private void xtremebtn_Click(object sender, EventArgs e)
        {
            tbctrl.Visible = true;
            tbctrl.SelectedTab = xtremewindow;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            tbctrl.Visible = false;
        }

        private void closext_Click(object sender, EventArgs e)
        {
            tbctrl.Visible = false;
        }

        private void closech_Click(object sender, EventArgs e)
        {
            tbctrl.Visible = false;
        }
    }
}
