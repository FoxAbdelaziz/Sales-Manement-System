using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Sales_Manement_System.PL
{
    public partial class FormCategory : Form
    {
        DatabaseSMPEntities db = new DatabaseSMPEntities();

        TableCategory TB_Cat = new TableCategory();
        int idCat;


        public FormCategory()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Sales_Manement_System.DatabaseSMPEntities dbContext = new Sales_Manement_System.DatabaseSMPEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TableCategories.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TableCategories.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void ptnAdd_Click(object sender, EventArgs e)
        {
            PL.FormAddCategory formAddCategory = new PL.FormAddCategory();
            formAddCategory.ID = 0;
            formAddCategory.ptnAdd.Text = "اضافة";
            formAddCategory.Text = "";
            formAddCategory.ShowDialog();

            Updte_Data();
        }

        private void ptnUpdate_Click(object sender, EventArgs e)
        {
            PL.FormAddCategory formAddCategory = new PL.FormAddCategory();
            formAddCategory.ptnAdd.Text = "تعديل";
            formAddCategory.Text = "";
            formAddCategory.ID = 1;
            formAddCategory.ShowDialog();

            Updte_Data();
        }

        private void ptnShowData_Click(object sender, EventArgs e)
        {
            Updte_Data();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            Updte_Data();
        }

        private void ptnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                idCat = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                //  MessageBox.Show(idCat.ToString());

                var result =
                MessageBox.Show("عملية حذف", "هل انت من متاكد من العملية", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    TB_Cat = db.TableCategories.Where(x => x.ID == idCat).FirstOrDefault();
                    db.Entry(TB_Cat).State = EntityState.Deleted;
                    db.SaveChanges();
                    Updte_Data();

                    
                }
                EPL.FormToast formToast = new EPL.FormToast();
                formToast.lblNotifcation.Text = "تم حذف الصنف بنجاح";
                formToast.ShowDialog();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void Updte_Data()
        {
            db = new DatabaseSMPEntities();
            gridControl1.DataSource = db.TableCategories.ToList();
        }
    }
}
