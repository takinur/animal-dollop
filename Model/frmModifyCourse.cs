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
    public partial class frmModifyCourse : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmModifyCourse()
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


        private void frmModifyCourse_Load(object sender, EventArgs e)
        {
            //Combo box Data
            comboValue();

            pnlError.Visible = false;
        }
        //Combo box Value
        private void comboValue()
        {
            db = new wTrackerDBEntities();
            //Animals
            var datra = db.animals.ToList();
            cboAnimal.DataSource = datra;
            cboAnimal.DisplayMember = "name";
            cboAnimal.ValueMember = "animal_Id";
            //Staff
            var data = db.staffs.ToList();
            cboStaff.DataSource = data;
            cboStaff.DisplayMember = "name";
            cboStaff.ValueMember = "staff_Id";

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
            if (string.IsNullOrEmpty(cboAnimal.Text))
            {
                showError("Please Select Animal!");
                return true;
            }//Staff
            else if (string.IsNullOrEmpty(cboStaff.Text))
            {
                showError("Please Select Staff!");
                return true;
            }//Goal
            else if (string.IsNullOrEmpty(cboGoal.Text))
            {
                showError("Please Select Goal!");
                return true;
            }

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsCoModify.Id == 0)
            {

                //Add New Data 
                addNewData();

            }
            else
            {
                //Update Current data
                update();

                //SET CourseID
                clsCoModify.Id = 0;

            }
        }
        private void update()
        {
            db = new wTrackerDBEntities();

            if (!Validate())
            {
                var updata = db.courses.Where(d => d.Id == clsCoModify.Id).FirstOrDefault();
                updata.start_date = dtStart.Value;
                updata.end_date = dtEnd.Value;
                updata.animal_Id = Int32.Parse(cboAnimal.SelectedValue.ToString());
                updata.staff_id = Int32.Parse(cboStaff.SelectedValue.ToString());
                updata.goal = cboGoal.SelectedItem.ToString();
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Course Information Edited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                    //New Course Data Insert 
                    course ant = new course();
                    ant.start_date = dtStart.Value;
                    ant.end_date = dtEnd.Value;
                    ant.animal_Id = Int32.Parse(cboAnimal.SelectedValue.ToString());
                    ant.staff_id = Int32.Parse(cboStaff.SelectedValue.ToString());
                    ant.goal = cboGoal.SelectedItem.ToString();

                    //BMI Calculation
                    var adata = db.animals.Where(t => t.animal_Id == ant.animal_Id).FirstOrDefault();

                    var weight = adata.weight;
                    var height = adata.height;
                    var bmi = (weight / (height * height));
                    ant.BMI = Double.Parse(String.Format("{0:.##}", bmi));

                    db.courses.Add(ant);
                    db.SaveChanges();
                    MessageBox.Show("Course Added Successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            lblTitle.Text = "Update Course Information";
            lblIDName.Visible = true;
            lblID.Visible = true;
            lblID.Text = clsCoModify.Id.ToString();
            cboAnimal.SelectedItem = clsCoModify.animal;
            dtStart.Value = clsCoModify.Sdate;
            dtEnd.Value = clsCoModify.Edate;
            cboStaff.SelectedItem = clsCoModify.staff;
            cboGoal.SelectedItem = clsCoModify.goal;

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

        private void tmrError_Tick(object sender, EventArgs e)
        {
            tmrError.Stop();
            pnlError.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            clsCoModify.Id = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            clsCoModify.Id = 0;
        }
    }
}
