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
    public partial class frmStaffList : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmStaffList()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            openForm(new frmModifyStaff());
        }

        private void frmStaffList_Load(object sender, EventArgs e)
        {
            alldata();
        }
        //ALL Staff
        private void alldata()
        {
            db = new wTrackerDBEntities();
            //Select Staff Data
            var data = db.staffs.Select(t => new { Id = t.staff_Id, t.name, t.age, t.deg, org = t.organization.Name }).ToList();

            dTable.AutoGenerateColumns = false;

            //Bind data to Gridview
            dTable.Columns[0].DataPropertyName = "Id";
            dTable.Columns[1].DataPropertyName = "name";
            dTable.Columns[2].DataPropertyName = "age";
            dTable.Columns[3].DataPropertyName = "deg";
            dTable.Columns[4].DataPropertyName = "org";

            dTable.DataSource = data;
        }

        private void dTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) //Edit Staff
            {
                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        //Selected Row Data store to Memory
                        clsStModify.Id = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        clsStModify.Name = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        clsStModify.Age = dTable.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                        clsStModify.Deg = dTable.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                        clsStModify.Org = dTable.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

                        dTable.CurrentRow.Selected = true;

                        frmModifyStaff mod = new frmModifyStaff();
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
            if (e.ColumnIndex == 6) //Delete Staff
            {

                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        int rowId = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        string rowAName = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        dTable.CurrentRow.Selected = true;

                        var data = db.staffs.Where(d => d.staff_Id == rowId).FirstOrDefault();

                        //Confirmation before Deleting
                        DialogResult dialogResult = MessageBox.Show("Deleting Staff Named: " + rowAName + "! Are you sure?", "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.staffs.Remove(data);
                            db.SaveChanges();
                            alldata();
                            MessageBox.Show("Staff Deleted Successfully! ", "Remove Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
