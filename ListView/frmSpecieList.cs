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
    public partial class frmSpecieList : Form
    {
        wTrackerDBEntities db;
        public frmSpecieList()
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
        private void frmSpecieList_Load(object sender, EventArgs e)
        {
            alldata();
        }
        //ALL Species
        private void alldata()
        {
            db = new wTrackerDBEntities();
            //Select Speicies Data
            var data = db.species.Select(t => new { Id = t.species_Id, t.name, t.description }).ToList();

            dTable.AutoGenerateColumns = false;

            //Bind data to Gridview
            dTable.Columns[0].DataPropertyName = "Id";
            dTable.Columns[1].DataPropertyName = "name";
            dTable.Columns[2].DataPropertyName = "description";

            dTable.DataSource = data;
        }
    
        private void dTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) //Edit Species
            {
                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        //Selected Row Data store to Memory
                        clsSpModify.Id = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        clsSpModify.Name = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        clsSpModify.Des = dTable.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();

                        dTable.CurrentRow.Selected = true;

                        frmSpModify mod = new frmSpModify();
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
            if (e.ColumnIndex == 4) //Delete Species
            {

                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        int rowId = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        string rowAName = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        dTable.CurrentRow.Selected = true;

                        var data = db.species.Where(d => d.species_Id == rowId).FirstOrDefault();

                        //Confirmation before Deleting
                        DialogResult dialogResult = MessageBox.Show("Deleting Species Named: " + rowAName + " ! Are you sure?", "Delete Specie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.species.Remove(data);
                            db.SaveChanges();
                            alldata();
                            MessageBox.Show("Specie Deleted Successfully! ", "Removed Species", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            //Do nothing
                            alldata();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show( "Delete Failed" + ex , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            openForm(new frmSpModify());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            alldata();
        }
    }
}
