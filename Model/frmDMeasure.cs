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
    public partial class frmDMeasure : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmDMeasure()
        {
            InitializeComponent();
        }

        private void frmDMeasure_Load(object sender, EventArgs e)
        {
            //Combo box Data
            comboValue();

            pnlError.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {

                db = new wTrackerDBEntities();

                try
                {
                    //New Daily Measurement Insert 
                    daily_measurement ant = new daily_measurement();
                    ant.log_id = Int32.Parse(cboLoID.SelectedValue.ToString());
                    ant.waist_size = Int32.Parse(txtWz.Text);
                    ant.weight = Int32.Parse(txtWeight.Text);
                    ant.shift = cboShift.Text;
                    ant.date = dtDate.Value;

                    db.daily_measurement.Add(ant);
                    db.SaveChanges();
                    MessageBox.Show("Daily Measurement Added Successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear All Filed
                    cboLoID.SelectedItem = "";
                    txtWz.Text = "";
                    txtWeight.Text = "";
                    cboShift.Text = "";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Data!" + ex, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void tmrError_Tick(object sender, EventArgs e)
        {
            tmrError.Stop();
            pnlError.Visible = false;
        }
        //Combo box Value
        private void comboValue()
        {
            db = new wTrackerDBEntities();
            //Logs
            var datra = db.daily_log.ToList();
            cboLoID.DataSource = datra;
            cboLoID.DisplayMember = "log_Id";
            cboLoID.ValueMember = "log_Id";
         

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
            // Log ID
            if (string.IsNullOrEmpty(cboLoID.Text))
            {
                showError("Please Select Log ID!");
                return true;
            }//Waist Size
            else if (string.IsNullOrEmpty(txtWz.Text))
            {
                showError("Please Enter Waist Size!");
                return true;
            }//Weight
            else if (string.IsNullOrEmpty(txtWeight.Text))
            {
                showError("Please Enter Weight!");
                return true;
            }//Shift
            else if (string.IsNullOrEmpty(cboShift.Text))
            {
                showError("Please Select Shift!");
                return true;
            }


            return false;
        }
    }
}
