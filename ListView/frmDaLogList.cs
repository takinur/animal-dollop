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
    public partial class frmDaLogList : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmDaLogList()
        {
            InitializeComponent();
        }

        private void frmDaLogList_Load(object sender, EventArgs e)
        {
            alldata();
        }
        private void alldata() {
             db = new wTrackerDBEntities();
            //Select Log Data
             var data = db.daily_log.Select(t => new { Id = t.log_Id, an = t.course.animal.name, act = t.activity.Name, dt = t.date, prg = t.progress, st = t.course.staff.name, go = t.course.goal}).ToList();

             dTable.AutoGenerateColumns = false;

            //Bind data to Gridview
            dTable.Columns[0].DataPropertyName = "Id";
            dTable.Columns[1].DataPropertyName = "an";
            dTable.Columns[2].DataPropertyName = "act";
            dTable.Columns[3].DataPropertyName = "dt";
            dTable.Columns[4].DataPropertyName = "prg";
            dTable.Columns[5].DataPropertyName = "st";
            dTable.Columns[6].DataPropertyName = "go";

            dTable.DataSource = data;        
        }

        private void dTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7) //Delete Log
            {

                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        int rowId = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());                       

                        dTable.CurrentRow.Selected = true;

                        var data = db.daily_log.Where(d => d.log_Id == rowId).FirstOrDefault();

                        //Confirmation before Deleting
                        DialogResult dialogResult = MessageBox.Show("Deleting LOG ID: " + rowId + " ! Are you sure?", "Delete Daily Log", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.daily_log.Remove(data);
                            db.SaveChanges();
                            alldata();
                            MessageBox.Show("Log Deleted Successfully! ", "Removed Log", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
