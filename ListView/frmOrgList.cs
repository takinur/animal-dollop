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
    public partial class frmOrgList : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmOrgList()
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

        private void frmOrgList_Load(object sender, EventArgs e)
        {
            alldata();
        }
        //ALL Organization
        private void alldata()
        {
            db = new wTrackerDBEntities();
            //Select Organizations Data
            var data = db.organizations.Select(t => new { Id = t.Organization_Id, t.Name, t.Address, orgType = t.organizationType.type }).ToList();

            dTable.AutoGenerateColumns = false;

            //Bind data to Gridview
            dTable.Columns[0].DataPropertyName = "Id";
            dTable.Columns[1].DataPropertyName = "Name";
            dTable.Columns[2].DataPropertyName = "Address";
            dTable.Columns[3].DataPropertyName = "orgType";

            dTable.DataSource = data;
        }

        private void dTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) //Edit Organization
            {
                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        //Selected Row Data store to Memory
                        clsOrgModify.Id = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        clsOrgModify.Name = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        clsOrgModify.Address = dTable.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                        clsOrgModify.Type = dTable.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                       
                        dTable.CurrentRow.Selected = true;

                        frmOrgModify mod = new frmOrgModify();
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
            if (e.ColumnIndex == 5) //Delete Organization
            {

                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        int rowId = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        string rowAName = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        dTable.CurrentRow.Selected = true;

                        var data = db.organizations.Where(d => d.Organization_Id == rowId).FirstOrDefault();

                        //Confirmation before Deleting
                        DialogResult dialogResult = MessageBox.Show("Deleting Organization Named: " + rowAName + " ! Are you sure?", "Delete Organization", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.organizations.Remove(data);
                            db.SaveChanges();
                            alldata();
                            MessageBox.Show("Organization Deleted Successfully! ", "Removed Organization ", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            openForm(new frmOrgModify());
        }
    }
}
