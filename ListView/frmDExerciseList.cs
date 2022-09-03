using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalWeightTracker_00183727.ListView
{
    public partial class frmDExerciseList : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmDExerciseList()
        {
            InitializeComponent();
        }

        private void frmDExerciseList_Load(object sender, EventArgs e)
        {
            alldata(); 
        }
        private void alldata()
        {
            db = new wTrackerDBEntities();
            //Select Daily Ex Data
            var data = db.daily_exercise.Select(t => new { Id = t.Id, lod = t.log_id, exn = t.exercise.name, tm = t.time, cb = t.exercise.calories_burn }).ToList();

            dTable.AutoGenerateColumns = false;

            //Bind data to Gridview
            dTable.Columns[0].DataPropertyName = "Id";
            dTable.Columns[1].DataPropertyName = "lod";
            dTable.Columns[2].DataPropertyName = "exn";
            dTable.Columns[3].DataPropertyName = "tm";
            dTable.Columns[4].DataPropertyName = "cb";


            dTable.DataSource = data;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            alldata();
        }

        private void dTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) //Delete Daily Exercise
            {

                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        int rowId = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());

                        dTable.CurrentRow.Selected = true;

                        var data = db.daily_exercise.Where(d => d.Id == rowId).FirstOrDefault();

                        //Confirmation before Deleting
                        DialogResult dialogResult = MessageBox.Show("Deleting Daily Exercie ID: " + rowId + " ! Are you sure?", "Delete Daily Log", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.daily_exercise.Remove(data);
                            db.SaveChanges();
                            alldata();
                            MessageBox.Show("Daily Exercise Deleted Successfully! ", "Removed Daily Exercise", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            //Do nothing
                            alldata();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete Failed" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
