using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace animalWeightTracker_00183727.ListView
{
    public partial class frmDMeasurementList : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmDMeasurementList()
        {
            InitializeComponent();
            chMes.ChartAreas["ChartArea1"].AxisX.Title = "Day";
            chMes.ChartAreas["ChartArea1"].AxisY.Title = "Weight";
         
        }

        private void frmDMeasurementList_Load(object sender, EventArgs e)
        {
            db = new wTrackerDBEntities();
            //Animals 
            
            var datra = db.animals.ToList();
            cboAnimal.DataSource = datra;
            cboAnimal.DisplayMember = "name";
            cboAnimal.ValueMember = "animal_Id";
            lblEr.Visible = true;

            //Hide Labels
            lblAw.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lblLG.Visible = false;
            lblgl.Visible = false;
            label7.Visible = false;
            //All Measurement to gridview
            alldata();

        }
        private void alldata()
        {
            db = new wTrackerDBEntities();
            //Select Daily Ex Data
            var dmdata = db.daily_measurement.Select(t => new { Id = t.log_id, nm =  t.daily_log.course.animal.name, ws = t.waist_size, wt = t.weight, t.shift, t.date }).ToList();

            dTable.AutoGenerateColumns = false;

            //Bind data to Gridview
            dTable.Columns[0].DataPropertyName = "Id";
            dTable.Columns[1].DataPropertyName = "nm";
            dTable.Columns[2].DataPropertyName = "ws";
            dTable.Columns[3].DataPropertyName = "wt";
            dTable.Columns[4].DataPropertyName = "shift";
            dTable.Columns[5].DataPropertyName = "date";


            dTable.DataSource = dmdata;
        }
        private void btn3D_Click_1(object sender, EventArgs e)
        {
            //3D 
            
            if (btn3D.Text == "3D")
            {
                chMes.ChartAreas[0].Area3DStyle.Enable3D = true;
                btn3D.Text = "2D";
            }
            else
            {
                chMes.ChartAreas[0].Area3DStyle.Enable3D = false;
                btn3D.Text = "3D";
            }
        }

       
        private void cboAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {

          
            
        }
        private void btnType_Click_1(object sender, EventArgs e)
        {
            //Change Chart Type
            chMes.Series[0].ChartType = SeriesChartType.Line;

            if (btnType.Text == "Line")
            {
                chMes.Series[0].ChartType = SeriesChartType.Line;
                btnType.Text = "Spline";
            }
            else if (btnType.Text == "Spline")
            {
                chMes.Series[0].ChartType = SeriesChartType.Spline;
                btnType.Text = "Step";
            }
            else if (btnType.Text == "Step")
            {
                chMes.Series[0].ChartType = SeriesChartType.StepLine;
                btnType.Text = "Line";
            }

        }

        private void cboAnimal_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int anID =  Int32.Parse(cboAnimal.SelectedValue.ToString());

            if (anID.ToString() != null)
            {
                lblEr.Visible = false;
                var chData = db.daily_measurement.Where(d => d.daily_log.course.animal.animal_Id == anID).ToList();

                chMes.DataSource = chData;
                chMes.Series["Daily Measurement"].XValueMember = "date";
                chMes.Series["Daily Measurement"].YValueMembers = "weight";
                chMes.Series["Daily Measurement"].XValueType = ChartValueType.Date;
                chMes.Series[0].ChartType = SeriesChartType.Line;

                //Total Weight Based on Animal
                var msum = db.daily_measurement.Where(t => t.daily_log.course.animal.animal_Id == anID).Sum(d => d.weight);
                //Count for Average
                var count = db.daily_measurement.Count(t => t.daily_log.course.animal.animal_Id == anID);
                //Average Weight
                var avg = msum / count;

                //First day Weight
                var fw = db.animals.Where(t => t.animal_Id == anID).FirstOrDefault();
                Double weight = Double.Parse(fw.weight.ToString());

                //Weight Loss Gain
                var wlg = avg - weight; 

                //Show  Labels
                lblAw.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                lblLG.Visible = true;
                lblgl.Visible = true;
                label7.Visible = true;              
            

                lblAw.Text = String.Format("{0:.##}", avg);
                lblLG.Text = String.Format("{0:.##}", wlg);
            }
            else
            {
                lblEr.Visible = true;
            }


        }
    }
}
