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
    public partial class frmDailyMeal : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmDailyMeal()
        {
            InitializeComponent();
        }

        private void frmDailyMeal_Load(object sender, EventArgs e)
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
                    //New Daily Meal Insert 
                    daily_meal ant = new daily_meal();
                    ant.log_id = Int32.Parse(cboLog.SelectedValue.ToString());
                    ant.meal_id = Int32.Parse(cboMeal.SelectedValue.ToString());
                    ant.meal_intake =Convert.ToDouble(txtMtake.Text);

                    db.daily_meal.Add(ant);
                    db.SaveChanges();
                    MessageBox.Show("Daily Meal Added Successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear All Filed
                    cboLog.SelectedItem = "";
                    cboMeal.SelectedItem = "";
                    txtMtake.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Data!" + ex, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }


        //Combo box Value
        private void comboValue()
        {
            db = new wTrackerDBEntities();
            //Logs
            var datra = db.daily_log.ToList();
            cboLog.DataSource = datra;
            cboLog.DisplayMember = "log_Id";
            cboLog.ValueMember = "log_Id";

            //Meal
            var data = db.meals.ToList();
            cboMeal.DataSource = data;
            cboMeal.DisplayMember = "name";
            cboMeal.ValueMember = "Id";


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
            // Log ID
            if (string.IsNullOrEmpty(cboLog.Text))
            {
                showError("Please Select Log ID!");
                return true;
            }//Meal
            else if (string.IsNullOrEmpty(cboMeal.Text))
            {
                showError("Please Select Meal!");
                return true;
            }//meal Intake
            else if (string.IsNullOrEmpty(txtMtake.Text))
            {
                showError("Please Enter Meal Intake!");
                return true;
            }


            return false;
        }
    }
}
