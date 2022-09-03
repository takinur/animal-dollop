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
    public partial class frmCourseList : Form
    {
        wTrackerDBEntities db;
        public frmCourseList()
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

        private void frmCourseList_Load(object sender, EventArgs e)
        {
            alldata();
        }
        //ALL Course
        private void alldata()
        {
            db = new wTrackerDBEntities();
            //Select Course Data
            var data = db.courses.Select(t => new { Id = t.Id, t.start_date, t.end_date, an= t.animal.name, sn = t.staff.name, t.goal, t.BMI  }).ToList();

            dTable.AutoGenerateColumns = false;

            //Bind data to Gridview
            dTable.Columns[0].DataPropertyName = "Id";
            dTable.Columns[1].DataPropertyName = "an";
            dTable.Columns[2].DataPropertyName = "start_date";
            dTable.Columns[3].DataPropertyName = "end_date";            
            dTable.Columns[4].DataPropertyName = "sn";
            dTable.Columns[5].DataPropertyName = "goal";
            dTable.Columns[6].DataPropertyName = "BMI";

            dTable.DataSource = data;
        }

        private void dTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7) //Edit Course
            {
                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        //Selected Row Data store to Memory
                        clsCoModify.Id = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                        clsCoModify.animal = dTable.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                        clsCoModify.Sdate = Convert.ToDateTime(dTable.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                        clsCoModify.Edate = Convert.ToDateTime(dTable.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                        clsCoModify.staff = dTable.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                        clsCoModify.goal = dTable.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();

                        dTable.CurrentRow.Selected = true;

                        frmModifyCourse mod = new frmModifyCourse();
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
            if (e.ColumnIndex == 8) //Delete Course
            {

                if (dTable.SelectedCells.Count > 0)
                {
                    try
                    {
                        int rowId = Int32.Parse(dTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                       
                        dTable.CurrentRow.Selected = true;

                        var data = db.courses.Where(d => d.Id == rowId).FirstOrDefault();

                        //Confirmation before Deleting
                        DialogResult dialogResult = MessageBox.Show("Deleting Course. ID: " + rowId + " ! Are you sure?", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.courses.Remove(data);
                            db.SaveChanges();
                            alldata();
                            MessageBox.Show("Course Deleted Successfully! ", "Removed Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            openForm(new frmModifyCourse());
        }
    }
}
