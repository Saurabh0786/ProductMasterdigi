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

namespace ProductMaster
{
    public partial class Frm_ProductType : Form
    {
        private ProductType model = new ProductType();
        public Frm_ProductType()
        {
            InitializeComponent();
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Clear();
            txtName.Focus();
        }
        void Clear()
        {
            txtName.Text = txtRemark.Text = "";
            btnAdd.Text = "Save";
            btnDelete.Enabled = false;
            model.ID = 0;
        }

        private void Frm_ProductType_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
            dgvproducttype.CellDoubleClick += dgvproducttype_CellDoubleClick;
        }

          private void dgvproducttype_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvproducttype.Rows[e.RowIndex];
            var id = (int)row.Cells["ID"].Value;
            if (id > 0)
            {

                using (ProductType1Entities db = new ProductType1Entities())
                {
                    var model = db.ProductTypes.Where(x => x.ID == id).FirstOrDefault();
                      txtName.Text = model.Name;
                      txtRemark.Text = model.Remark;
                }
                btnAdd.Text = "Update";
                btnDelete.Enabled = true;
            }
          }

   

        private void PopulateDataGridView()
        {
            {
                dgvproducttype.AutoGenerateColumns = false;
            }
            using (ProductType1Entities db = new ProductType1Entities())
            {
                dgvproducttype.DataSource = db.ProductTypes.ToList<ProductType>();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            using (var context = new ProductType1Entities())
            {
                var model_ProductType  = new ProductType();
                string Name = txtName.Text;
                var model = context.ProductTypes.Where(a => a.Name == Name).FirstOrDefault();
                if (model!= null)
                {
                    context.ProductTypes.Remove(model);
                    context.SaveChanges();
                    PopulateDataGridView();
                    MessageBox.Show("Product Deleted Successfully");
                }
            }
        }
           private void btnSave_Click_1(object sender, EventArgs e)
        {
          
        }

        private void Load_Data_Grid()
        {
            throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ProductType1Entities())
                {
                    var model_ProductType = new ProductType();
                    string Name = txtName.Text;

                    model_ProductType.Name = txtName.Text;
                    model_ProductType.Remark = txtRemark.Text;

                    var model = context.ProductTypes.Where(a => a.Name == Name).FirstOrDefault();
                    if (model == null)
                    {
                        context.ProductTypes.Add(model_ProductType);
                    }
                    else
                    {
                        var entry = context.Entry(model);
                        entry.CurrentValues.SetValues(model_ProductType);
                        entry.State = System.Data.Entity.EntityState.Modified;

                    }

                    context.SaveChanges();
                    Load_Data_Grid();

                }
                MessageBox.Show("Product Added Successfully!");


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }
    }




    }
   

        
   

    
        



        
        
       

       