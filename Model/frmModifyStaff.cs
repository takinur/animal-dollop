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
using animalWeightTracker_00183727.Model;

namespace animalWeightTracker_00183727
{
    public partial class frmModifyStaff : Form
    {
        //DB
        wTrackerDBEntities db;
       
        public frmModifyStaff()
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

       

        private void btnSav_Click(object sender, EventArgs e)
        {
            if (clsStModify.Id == 0)
            {

                //Add New Data 
                addNewData();
          

            }
            else
            {
                //Update Current data
                update();

                //SET animal ID
                clsStModify.Id = 0;


            }
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            this.Close();
            clsStModify.Id = 0;
        }

        private void frmModifyStaff_Load(object sender, EventArgs e)
        {
            //Combo Data
            db = new wTrackerDBEntities();
            var data = db.organizations.ToList();
            cboOrg.DataSource = data;
            cboOrg.DisplayMember = "Name";
            cboOrg.ValueMember = "Organization_Id";
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
                showError("Please Enter Name!");
                return true;
            }//Age
            else if (string.IsNullOrEmpty(txtAge.Text))
            {
                showError("Please Enter Age!");
                return true;
            }
            //Gender
            else if (string.IsNullOrEmpty(txtDeg.Text))
            {
                showError("Please Enter Designation!");
                return true;
            }

            return false;
        }
        private void update()
        {
            db = new wTrackerDBEntities();

            if (!Validate())
            {
                var updata = db.staffs.Where(d => d.staff_Id == clsStModify.Id).FirstOrDefault();
                updata.name = txtName.Text;
                updata.age = txtAge.Text;
                updata.deg = txtDeg.Text;
                updata.org_id = Int32.Parse(cboOrg.SelectedValue.ToString());
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Staff Information Edited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                    //New Staff Data Insert 
                    staff ant = new staff();
                    ant.name = txtName.Text;
                    ant.age = txtAge.Text;
                    ant.deg= txtDeg.Text;                    
                    ant.org_id = Int32.Parse(cboOrg.SelectedValue.ToString());

                    db.staffs.Add(ant);
                    db.SaveChanges();
                    MessageBox.Show("New Staff Added Successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            lblTitle.Text = "Update Staff Information";
            lblIDName.Visible = true;
            lblID.Visible = true;
            lblID.Text = clsStModify.Id.ToString();
            txtName.Text = clsStModify.Name;
            txtAge.Text = clsStModify.Age;
            txtDeg.Text = clsStModify.Deg;           
            cboOrg.SelectedItem = clsStModify.Org;

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
            // Timer
            tmrError.Stop();
            pnlError.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
