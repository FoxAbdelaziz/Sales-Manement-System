using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales_Manement_System.EPL;

namespace Sales_Manement_System.PL
{
    public partial class FormAddCategory : Form
    {
        DatabaseSMPEntities db = new DatabaseSMPEntities();
        TableCategory cat = new TableCategory();
        BL.ClassMethods m = new BL.ClassMethods();
        PL.FormCategory formCategory = new FormCategory();

        public int ID;
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void ptnAdd_Click(object sender, EventArgs e)
        {
            FormToast formToast = new FormToast();
            FormDialog formDialog = new FormDialog();

            if (txtName.Text == "")
            {
                //formDialog.Width = this.Width;
                //formDialog.lblNotifcation.Text = "اسم الصنف مطلوب";
                //formDialog.ShowDialog();
                txtName.Focus();
                errorProvider1.SetError(txtName , "اسم الصنف مطلوب");  
            }
            else
            {
                if (ID == 0)
                {
                    picCategory.Image.Save(m.MS, System.Drawing.Imaging.ImageFormat.Png);
                    cat.CAT_Name = txtName.Text;
                    cat.CAT_Image = m.convert_byte();
                    db.TableCategories.Add(cat);
                    db.SaveChanges();

                    formToast.lblNotifcation.Text = "تم اضافة الصنف بنجاح";
                    formToast.ShowDialog();
                    db = new DatabaseSMPEntities();
                    formCategory.gridControl1.DataSource = db.TableCategories.ToList();

                    this.Close();

                }
                else
                {

                }
            }
        }

        private void ptnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
