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
using animalWeightTracker_00183727.ListView;

namespace animalWeightTracker_00183727.Model
{
    public partial class frmSpModify : Form
    {
        //DB
        wTrackerDBEntities db = new wTrackerDBEntities();
        public frmSpModify()
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

        private void frmSpModify_Load(object sender, EventArgs e)
        {
            /*
            // Form Set To Insert Mode */
            pnlError.Visible = false;         
       
           
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsSpModify.Id == 0)
            {

                //Insert New Data 
                addNewData();   
                   

            }
            else
            {
                //Update Current data
                update();
               

                //RESET Species ID
                clsSpModify.Id = 0;


            }
        }

      
        private void update()
        {
           // db = new weightTrackerDBEntities();

            if (!Validate())
            {
                var updata = db.species.Where(d => d.species_Id == clsSpModify.Id).FirstOrDefault();
                updata.name = txtName.Text;
                updata.description = txtDes.Text;
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Species Information Edited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                //Insert New Species Data  
                species spt = new species();
                spt.name = txtName.Text;
                spt.description = txtDes.Text;
       
                try
                {
                    db.species.Add(spt);
                    db.SaveChanges();
                    MessageBox.Show("New Species Added Successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            lblTitle.Text = "Update Species Information";
            lblIDName.Visible = true;

            lblID.Text = clsSpModify.Id.ToString();
            txtName.Text = clsSpModify.Name;
            txtDes.Text = clsSpModify.Des;
            lblID.Visible = true;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            this.Close();

            //RESET Species ID
            clsSpModify.Id = 0;



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();

            //RESET Species ID
            clsSpModify.Id = 0;

        }
        //Error panel
        void showError(String text)
        {
            lblError.Text = text;
            pnlError.Visible = true;
            tmrError.Start();
        }
     
        // Validation
        private new bool Validate()
        {
            // Name
            if (string.IsNullOrEmpty(txtName.Text))
            {
                showError("Please Enter Animal Name!");
                return true;
            }//Description
            else if (string.IsNullOrEmpty(txtDes.Text))
            {
                showError("Please Enter Description!");
                return true;
            }
           
            return false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            clsSpModify.Id = 0;
            this.Close();
        }
    }
}
