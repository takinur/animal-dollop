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
    public partial class frmDaExercise : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmDaExercise()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDaExercise_Load(object sender, EventArgs e)
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
                    //New Daily Exercise Insert 
                    daily_exercise ant = new daily_exercise();
                    ant.log_id = Int32.Parse(cboLoID.SelectedValue.ToString());
                    ant.time = txtTime.Text;
                    ant.exercise_id = Int32.Parse(cboEx.SelectedValue.ToString());
                    
                    db.daily_exercise.Add(ant);
                    db.SaveChanges();
                    MessageBox.Show("Daily Exercise Added Successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear All Filed
                    cboLoID.SelectedItem = "";
                    cboEx.SelectedItem = "";
                    txtTime.Text = "";

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
            //Exercise
            var data = db.exercises.ToList();
            cboEx.DataSource = data;
            cboEx.DisplayMember = "Name";
            cboEx.ValueMember = "Id";


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
            }//Time
            else if (string.IsNullOrEmpty(txtTime.Text))
            {
                showError("Please Enter Time!");
                return true;
            }//exercise
            else if (string.IsNullOrEmpty(cboEx.Text))
            {
                showError("Please Select Exercise!");
                return true;
            }


            return false;
        }
    }
}
