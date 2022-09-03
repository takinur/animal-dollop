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
    public partial class frmMealList : Form
    {
        //DB
        wTrackerDBEntities db;
        public frmMealList()
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

        private void frmMealList_Load(object sender, EventArgs e)
        {
            alldata();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            openForm(new frmModifyMeal());
        }
        //ALL Meal
        private void alldata()
        {
            db = new wTrackerDBEntities();
            //Select Meal Data
            var data = db.meals.Select(t => new { t.Id, t.name, unit = t.unit_in_gram, t.caloriers }).ToList();

            dTable.AutoGenerateColumns = false;

            //Bind data to Gridview
            dTable.Columns[0].DataPropertyName = "Id";
            dTable.Columns[1].DataPropertyName = "name";
            dTable.Columns[2].DataPropertyName = "unit";
            dTable.Columns[3].DataPropertyName = "caloriers";

            dTable.DataSource = data;
        }

        private void dTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4) //Edit Meal
            {
                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        //Selected Row Data store to Memory
                        clsMlModify.Id = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        clsMlModify.name = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        clsMlModify.unit = Convert.ToDouble(dTable.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                        clsMlModify.calorie =Convert.ToDouble(dTable.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());


                        dTable.CurrentRow.Selected = true;

                        frmModifyMeal mod = new frmModifyMeal();
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
            if (e.ColumnIndex == 5) //Delete Meal
            {

                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        int rowId = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        string rowAName = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        dTable.CurrentRow.Selected = true;

                        var data = db.meals.Where(d => d.Id == rowId).FirstOrDefault();

                        //Confirmation before Deleting
                        DialogResult dialogResult = MessageBox.Show("Deleting Meal Named: " + rowAName + "! Are you sure?", "Delete Meal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.meals.Remove(data);
                            db.SaveChanges();
                            alldata();
                            MessageBox.Show("Meal Deleted Successfully! ", "Removed Meal", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
