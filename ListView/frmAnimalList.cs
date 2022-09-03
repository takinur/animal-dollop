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
    public partial class frmAnimalList : Form
    {
        wTrackerDBEntities db;

        public frmAnimalList()
        {
            InitializeComponent();
        }

        //Opening  only one sub form at a time
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
            openForm(new frmModifyAnimal());

        }

        private void frmAnimalList_Load(object sender, EventArgs e)
        {
            alldata();
        }

        //ALL Data from Animal
        public void alldata()
        {
            db = new wTrackerDBEntities();
            //Select Animal Data
            var data = db.animals.Select(t => new { Id = t.animal_Id, t.name, t.age, t.gender, t.weight, t.height, spName = t.species.name, orgName = t.organization.Name }).ToList();

            dTable.AutoGenerateColumns = false;

            //Bind data to Gridview
            dTable.Columns[0].DataPropertyName = "Id";
            dTable.Columns[1].DataPropertyName = "name";
            dTable.Columns[2].DataPropertyName = "age";
            dTable.Columns[3].DataPropertyName = "gender";
            dTable.Columns[4].DataPropertyName = "weight";
            dTable.Columns[5].DataPropertyName = "height";
            dTable.Columns[6].DataPropertyName = "spName";
            dTable.Columns[7].DataPropertyName = "orgName";

            dTable.DataSource = data;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            alldata();
        }

        private void dTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.ColumnIndex == 8) //Edit Animal Data
            {
                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        clsAnModify an = new clsAnModify();

                        //Selected Row Data store to Memory
                        clsAnModify.Id = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        an.Name = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        clsAnModify.Age = dTable.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                        clsAnModify.Gender = dTable.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                        clsAnModify.weight = Double.Parse(dTable.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                        clsAnModify.height = Double.Parse(dTable.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());                     
                        clsAnModify.Spec = dTable.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                        clsAnModify.Org = dTable.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();

                        dTable.CurrentRow.Selected = true;

                        frmModifyAnimal mod = new frmModifyAnimal();                        
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
            if (e.ColumnIndex == 9) //Delete Animal 
            {

                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    { 
                        int rowId = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        string rowAName = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        dTable.CurrentRow.Selected = true;

                        var data = db.animals.Where(d => d.animal_Id == rowId).FirstOrDefault();
                       
                        //Confirmation before Deleting
                        DialogResult dialogResult = MessageBox.Show("Deleting Animal Named: " + rowAName + " ! Are you sure?", "Delete Animal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.animals.Remove(data);
                            db.SaveChanges();
                            alldata();
                            MessageBox.Show("Animal Deleted Successfully! ", "Removed Animal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            //Do nothing
                            alldata();
                        }                         

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }


            }
        }

    }
}
