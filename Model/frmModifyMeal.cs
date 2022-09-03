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
    public partial class frmModifyMeal : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmModifyMeal()
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
        private void frmModifyMeal_Load(object sender, EventArgs e)
        {
           pnlError.Visible = false;
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
                showError("Please Enter Meal Name!");
                return true;
            }//Unit
            else if (string.IsNullOrEmpty(txtUnit.Text))
            {
                showError("Please Enter Unit in Gram!");
                return true;
            }
            //Calorie
            else if (string.IsNullOrEmpty(txtCalorie.Text))
            {
                showError("Please Calorie!");
                return true;
            }

            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            clsMlModify.Id = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            clsMlModify.Id = 0;
        }

        private void tmrError_Tick(object sender, EventArgs e)
        {
            tmrError.Stop();
            pnlError.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsMlModify.Id == 0)
            {

                //Add New Data 
                addNewData();

            }
            else
            {
                //Update Current data
                update();

                //Reset ID
                clsMlModify.Id = 0;

            }
        }
        private void update()
        {
            db = new wTrackerDBEntities();

            if (!Validate())
            {
                var updata = db.meals.Where(d => d.Id == clsMlModify.Id).FirstOrDefault();
                updata.name = txtName.Text;
                updata.unit_in_gram = Convert.ToDouble(txtUnit.Text);
                updata.caloriers = Convert.ToDouble(txtCalorie.Text);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Meal Information Edited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                    
                    //New Meal Data Insert 
                    meal ml = new meal();
                    ml.name = txtName.Text;
                    ml.unit_in_gram = Convert.ToDouble(txtUnit.Text);
                    ml.caloriers = Convert.ToDouble(txtCalorie.Text);

                    db.meals.Add(ml);
                    db.SaveChanges();
                    MessageBox.Show("New Meal Added Successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            lblTitle.Text = "Update Meal Information";
            lblIDName.Visible = true;
            lblID.Visible = true;
            lblID.Text = clsMlModify.Id.ToString();
            txtName.Text = clsMlModify.name;
            txtUnit.Text = clsMlModify.unit.ToString() ;
            txtCalorie.Text = clsMlModify.calorie.ToString();

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
