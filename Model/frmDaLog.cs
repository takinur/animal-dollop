using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalWeightTracker_00183727.Model
{
    public partial class frmDaLog : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmDaLog()
        {
            InitializeComponent();
        }

        private void frmDaLog_Load(object sender, EventArgs e)
        {
            //Combo box Data
            comboValue();

            pnlError.Visible = false;
            dtDate.Value = DateTime.Now;
            dtDate.Enabled = false;
        }
        //Combo box Value
        private void comboValue()
        {
            db = new wTrackerDBEntities();
            //Course
            var datra = db.courses.ToList();
            cboCr.DataSource = datra;
            cboCr.DisplayMember = "Id";
            cboCr.ValueMember = "Id";
            //Activity
            var data = db.activities.ToList();
            cboAct.DataSource = data;
            cboAct.DisplayMember = "Name";
            cboAct.ValueMember = "activity_Id";
            

        }
        //Error panel
        void showError(String text)
        {
            lblError.Text = text;
            pnlError.Visible = true;
            tmrError.Start();
        }

        private void tmrError_Tick(object sender, EventArgs e)
        {
            tmrError.Stop();
            pnlError.Visible = false;
        }
        // Validation
        private new bool Validate()
        {
            // Course ID
            if (string.IsNullOrEmpty(cboCr.Text))
            {
                showError("Please Select Course ID!");
                return true;
            }//Activity
            else if (string.IsNullOrEmpty(cboAct.Text))
            {
                showError("Please Select Activity!");
                return true;
            }//Progress
            else if (string.IsNullOrEmpty(txtProg.Text))
            {
                showError("Please Enter Progress!");
                return true;
            }
            

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {

                db = new wTrackerDBEntities();

                try
                {
                    //New Daily Log Data Insert 
                    daily_log ant = new daily_log();
                    ant.course_id = Int32.Parse(cboCr.SelectedValue.ToString());
                    ant.activity_id = Int32.Parse(cboAct.SelectedValue.ToString());
                    ant.date = dtDate.Value;
                    ant.progress = txtProg.Text;
                    
                    db.daily_log.Add(ant);
                    db.SaveChanges();
                    MessageBox.Show("Log Added Successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear All Filed
                    cboCr.SelectedItem = "";
                    cboAct.SelectedItem = "";
                    txtProg.Text = "";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Data!" + ex, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
