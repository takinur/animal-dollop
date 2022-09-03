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
    public partial class frmMintakeList : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmMintakeList()
        {
            InitializeComponent();
        }

        private void frmMintakeList_Load(object sender, EventArgs e)
        {
            alldata();
        }
        private void alldata()
        {
            db = new wTrackerDBEntities();
            //Select Daily Meal Data
            var data = db.daily_meal.Select(t => new { Id = t.Id, lid = t.log_id, an = t.daily_log.course.animal.name, meal = t.meal.name, mt = t.meal_intake }).ToList();

            dTable.AutoGenerateColumns = false;

            //Bind data to Gridview
            dTable.Columns[0].DataPropertyName = "Id";
            dTable.Columns[1].DataPropertyName = "lid";
            dTable.Columns[2].DataPropertyName = "an";
            dTable.Columns[3].DataPropertyName = "meal";
            dTable.Columns[4].DataPropertyName = "mt";
         

            dTable.DataSource = data;
        }

        private void dTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) //Delete Dialy Meal
            {

                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        int rowId = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());

                        dTable.CurrentRow.Selected = true;

                        var data = db.daily_meal.Where(d => d.Id == rowId).FirstOrDefault();

                        //Confirmation before Deleting
                        DialogResult dialogResult = MessageBox.Show("Deleting Daily Meal ID: " + rowId + " ! Are you sure?", "Delete Daily Log", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.daily_meal.Remove(data);
                            db.SaveChanges();
                            alldata();
                            MessageBox.Show("Daily Meal Deleted Successfully! ", "Removed Daily Meal", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            alldata();
        }
    }
}
