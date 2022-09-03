using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalWeightTracker_00183727.Model
{
    public partial class frmModifyEx : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmModifyEx()
        {
            InitializeComponent();
        }
        //Dragging the form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void tmrError_Tick(object sender, EventArgs e)
        {
            tmrError.Stop();
            pnlError.Visible = false;
        }

        private void frmModifyEx_Load(object sender, EventArgs e)
        {
           
            pnlError.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsExModify.Id == 0)
            {

                //Add New Data 
                addNewData();

            }
            else
            {
                //Update Current data
                update();

                //Reset Exercise
                clsExModify.Id = 0;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            clsExModify.Id = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            clsExModify.Id = 0;
        }
        //Error panel
        void showError(String text)
        {
            lblError.Text = text;
            pnlError.Visible = true;
            tmrError.Start();
        }
        // Timer
        private void tmrError_Tick_1(object sender, EventArgs e)
        {
            tmrError.Stop();
            pnlError.Visible = false;
        }
        // Validation
        private new bool Validate()
        {
            // Name
            if (string.IsNullOrEmpty(txtName.Text))
            {
                showError("Please Enter Exercise Name!");
                return true;
            }//Staff
            else if (string.IsNullOrEmpty(txtTime.Text))
            {
                showError("Please Enter Time!");
                return true;
            }//Goal
            else if (string.IsNullOrEmpty(txtCalorie.Text))
            {
                showError("Please Enter Calorie Burn!");
                return true;
            }
            //BMI
            else if (string.IsNullOrEmpty(txtEx.Text))
            {
                showError("Please Enter Exercise Type!");
                return true;
            }

            return false;
        }
        private void update()
        {
            db = new wTrackerDBEntities();

            if (!Validate())
            {
                var updata = db.exercises.Where(d => d.Id == clsExModify.Id).FirstOrDefault();
                updata.name = txtName.Text;
                updata.time = txtTime.Text;
                updata.calories_burn = Convert.ToDouble(txtCalorie.Text);
                updata.exercise_type = txtEx.Text;
               
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Exercise Information Edited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Hide();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Invalid Data!" + ex, "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addNewData()
        {
            if (!Validate())
            {

                db = new wTrackerDBEntities();

                try
                {
                    //New Exercise Data Insert 
                    exercise ant = new exercise();
                    ant.name = txtName.Text;
                    ant.time = txtTime.Text;
                    ant.calories_burn = Convert.ToDouble(txtCalorie.Text);
                    ant.exercise_type = txtEx.Text;
                   
                    db.exercises.Add(ant);
                    db.SaveChanges();
                    MessageBox.Show("Exercise Added Successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Data!" + ex, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }




            }
        }

        //SET Form to Edit Mode
        public void frmupdt()
        {
            btnSave.Text = "Update";
            lblTitle.Text = "Update Exercise Information";
            lblIDName.Visible = true;
            lblID.Visible = true;
            lblID.Text = clsExModify.Id.ToString();
            txtName.Text = clsExModify.name;
            txtTime.Text = clsExModify.time;
            txtCalorie.Text = clsExModify.cal_burn.ToString();
            txtEx.Text = clsExModify.exType;
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Drag FORM
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
