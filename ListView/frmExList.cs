using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using animalWeightTracker_00183727.Model;

namespace animalWeightTracker_00183727.ListView
{
    public partial class frmExList : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmExList()
        {
            InitializeComponent();
        }
        //Opening only one Form at a time
        private Form activeForm = null;
        private void openForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.ShowDialog();
            alldata();
        }

        private void frmExList_Load(object sender, EventArgs e)
        {
            alldata();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            openForm(new frmModifyEx ());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            alldata();
        }

        private void dTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) //Edit Exercise
            {
                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        //Selected Row Data store to Memory
                        clsExModify.Id = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        clsExModify.name = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        clsExModify.time = dTable.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                        clsExModify.cal_burn = Convert.ToDouble(dTable.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                        clsExModify.exType = dTable.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

                        dTable.CurrentRow.Selected = true;

                        frmModifyEx mod = new frmModifyEx();
                        mod.frmupdt();
                        if (activeForm != null) activeForm.Close();
                        activeForm = mod;
                        mod.ShowDialog();
                        alldata();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            if (e.ColumnIndex == 6) //Delete Ex
            {

                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        int rowId = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        string rowAName = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        dTable.CurrentRow.Selected = true;

                        var data = db.exercises.Where(d => d.Id == rowId).FirstOrDefault();

                        //Confirmation before Deleting
                        DialogResult dialogResult = MessageBox.Show("Deleting Exercise Named: " + rowAName + "! Are you sure?", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.exercises.Remove(data);
                            db.SaveChanges();
                            alldata();
                            MessageBox.Show("Exercise Deleted Successfully! ", "Removed Exercise", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        //ALL Exercise
        private void alldata()
        {
            db = new wTrackerDBEntities();
            //Select Ex Data
            var data = db.exercises.Select(t => new { Id = t.Id, t.name, t.time, cb = t.calories_burn, et = t.exercise_type }).ToList();

            dTable.AutoGenerateColumns = false;

            //Bind data to Gridview
            dTable.Columns[0].DataPropertyName = "Id";
            dTable.Columns[1].DataPropertyName = "name";
            dTable.Columns[2].DataPropertyName = "time";
            dTable.Columns[3].DataPropertyName = "cb";
            dTable.Columns[4].DataPropertyName = "et";

            dTable.DataSource = data;
        }

    }
}
