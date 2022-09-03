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
    public partial class frmModifyAnimal : Form
    {
        //DB
        wTrackerDBEntities db;

        public frmModifyAnimal()
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            clsAnModify.Id = 0;
        }

        private void frmModifyAnimal_Load(object sender, EventArgs e)
        {
            
            //Combo box Data
            comboValue();           
            
            pnlError.Visible = false;
        }
        //Combo box Value
        private void comboValue()
        { 
            db = new wTrackerDBEntities();
            //Species
            var datra = db.species.ToList();
            cbospecies.DataSource = datra;
            cbospecies.DisplayMember = "name";
            cbospecies.ValueMember = "species_Id";
            //Organization
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
                showError("Please Enter Animal Name!");
                return true;
            }//Age
            else if (string.IsNullOrEmpty(txtAge.Text))
            {
                showError("Please Enter Age!");
                return true;
            }
            //Gender
            else if (string.IsNullOrEmpty(cboGender.Text))
            {
                showError("Please Select Gender!");
                return true;
            }

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsAnModify.Id == 0)
            {
                
                //Add New Data 
                addNewData();

            }
            else
            {
                //Update Current data
                update();

                //SET animal ID
                clsAnModify.Id = 0;       

            }

        }

        private void update()
        {
            db = new wTrackerDBEntities();
            
            if (!Validate())
            {
                var updata = db.animals.Where(d => d.animal_Id == clsAnModify.Id).FirstOrDefault();
                updata.name = txtName.Text;
                updata.age = txtAge.Text;
                updata.gender = cboGender.Text;
                updata.weight = Decimal.Parse(txtWeight.Text);
                updata.height = Decimal.Parse(txtHeight.Text);
                updata.species_Id = Int32.Parse(cbospecies.SelectedValue.ToString());
                updata.organization_Id = Int32.Parse(cboOrg.SelectedValue.ToString());
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Animal Information Edited Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                  
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
                    //New Animal Data Insert 
                    animal ant = new animal();
                    ant.name = txtName.Text;
                    ant.age = txtAge.Text;
                    ant.gender = cboGender.Text;
                    ant.weight = Decimal.Parse(txtWeight.Text);
                    ant.height= Decimal.Parse(txtHeight.Text);
                    ant.species_Id = Int32.Parse(cbospecies.SelectedValue.ToString());
                    ant.organization_Id = Int32.Parse(cboOrg.SelectedValue.ToString());
                   

                    db.animals.Add(ant);
                    db.SaveChanges();
                    MessageBox.Show("New Animal Added Successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
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
            clsAnModify oan = new clsAnModify();
            btnSave.Text = "Update";            
            lblTitle.Text = "Update Animal Information";
            lblIDName.Visible = true;            
            lblID.Visible = true;
            lblID.Text = clsAnModify.Id.ToString();
            txtName.Text = oan.Name;
            txtAge.Text = clsAnModify.Age;
            cboGender.Text = clsAnModify.Gender;
            txtWeight.Text = clsAnModify.weight.ToString();
            txtHeight.Text = clsAnModify.height.ToString();            
            cbospecies.SelectedItem = clsAnModify.Spec;
            cboOrg.SelectedItem = clsAnModify.Org;
            
        }
    
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            clsAnModify.Id = 0;

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
