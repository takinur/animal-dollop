using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using animalWeightTracker_00183727.ListView;
using animalWeightTracker_00183727.Model;

namespace animalWeightTracker_00183727
{
    public partial class frmMain : Form
    {
     
        //Dragging the form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
          
        }
        //Opening other forms Within This form
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //Submenu Hide 
        private void hideSubMenu()
        {
            if (pnlAnSub.Visible != false)
            {
                         
                pnlAnSub.Visible = false;
                
            }
            if (pnlStSub.Visible != false )
            {
                pnlStSub.Visible = false;
               
            }
            if (pnlDsub.Visible == true)
            {
                pnlDsub.Visible = false;
            }
            if (pnlRpsub.Visible == true)
            {
                pnlRpsub.Visible = false;
            }
            
            
            

        }
        //Submenu Show 
        private void showSubMenu(Panel pnlsub)
        {
            if (pnlsub.Visible == false)
            {
                hideSubMenu();
               
                pnlsub.Visible = true;
            }
            else
            {
                pnlsub.Visible = false;
            }
               
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            btnMax.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "../../Resources/maximize-window.png");
            hideAllSub();
            TIME.Enabled = true;
            openChildForm(new frmHome());

        }

        private void hideAllSub()
        {
            //Hide All Sub Menu
            pnlAnSub.Visible = false;
            pnlStSub.Visible = false;
            pnlDsub.Visible = false;
            pnlRpsub.Visible = false;
        }

        private void btnAnimal_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlAnSub);            
            
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlStSub);
            
        }

        private void pnltop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {

                this.WindowState = FormWindowState.Normal;
                btnMax.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "../../Resources/maximize-window.png");
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                btnMax.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "../../Resources/restore-window.png");
            }
            
        }

     

        private void btnAnView_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAnimalList());
        }

        private void btnSpecies_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSpecieList());
        }

        private void btnMinmz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAllOrg_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOrgList());
        }

        private void btnStaf_Click(object sender, EventArgs e)
        {
            openChildForm(new frmStaffList());
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            //Drag FORM
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnAnCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCourseList());
        }

        private void btnDr_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlDsub);
           
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlRpsub);
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMealList());
        }

        private void btnAex_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExList());
        }

        private void btnMi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDailyMeal());
        }

        private void btnDlog_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDaLog());
        }

        private void btnDmeas_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDMeasure());
        }

        private void btnDex_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDaExercise());
        }

        private void btnDlist_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDaLogList());
        }

        private void btnMlist_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMintakeList());
        }

        private void btnDexList_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDExerciseList());
        }

        private void btnMelist_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDMeasurementList());
        }

        private void TIME_Tick(object sender, EventArgs e)
        {
            
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd-MMM-yy");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new frmHome());
        }
    }
}
