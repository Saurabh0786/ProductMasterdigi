using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;



namespace ProductMaster
{
    public partial class Frm_ProductMaster : Form
    {
        private string imglocation;
        public Frm_ProductMaster()
        {
            InitializeComponent();
        }

        private void Frm_ProductMaster_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            Load_Data_Grid();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            var id = (int)row.Cells["ProductID"].Value;
            if (id > 0)
            {
                using (var context = new ProductMasterEntities())
                {
                    var obj_New = context.ProductUploads.Where(a => a.ProductID == id).FirstOrDefault();
                    txtPId.Text = obj_New.ProductID.ToString();
                   // txtPId.ReadOnly = true;
                    txtPName.Text = obj_New.ProductName;
                    pbbrowse.Image = ByteToImage(obj_New.ProductImage);

                }
            }

        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            try
            {
                MemoryStream mStream = new MemoryStream();
                byte[] pData = blob;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();
                return bm;
            }
            catch (Exception ee)
            {
                return null;
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var context = new ProductMasterEntities())
            {
                var obj_New_ProductUpload = new ProductUpload();
                var pId = Convert.ToInt32(txtPId.Text);
                var obj_db = context.ProductUploads.Where(a => a.ProductID == pId).FirstOrDefault();
                if (obj_db != null)
                {
                    context.ProductUploads.Remove(obj_db);
                    context.SaveChanges();
                    Load_Data_Grid();
                    MessageBox.Show("Product Deleted Successfully");
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Byte[] bindata=null;
                if (pbbrowse.ImageLocation!= null)
                {
                    FileStream fs = new FileStream(pbbrowse.ImageLocation.ToString(), FileMode.Open, FileAccess.Read); //Path is image location 
                    bindata = new byte[Convert.ToInt32(fs.Length)];
                    fs.Read(bindata, 0, Convert.ToInt32(fs.Length));
                }

                using (var context = new ProductMasterEntities())
                {
                    var obj_New_ProductUpload = new ProductUpload();
                    var pId = Convert.ToInt32(txtPId.Text);
                    obj_New_ProductUpload.ProductID = pId;
                    obj_New_ProductUpload.ProductName = txtPName.Text;
                    obj_New_ProductUpload.ProductImage = bindata;

                    var obj_db = context.ProductUploads.Where(a => a.ProductID == pId).FirstOrDefault();
                    if (obj_db == null)
                    {
                        context.ProductUploads.Add(obj_New_ProductUpload);
                    }
                    else
                    {
                        var entry = context.Entry(obj_db);
                        entry.CurrentValues.SetValues(obj_New_ProductUpload);
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
        //private void Set_db_Object_Value_MASTER(object db_BE, ProductUpload obj_db)
        //{
        //    throw new NotImplementedException();
        //}
        private void Load_Data_Grid()
        {
            try
            {
                var Coll_Data = new List<ProductUpload>();
                using (var context = new ProductMasterEntities())
                {
                    Coll_Data = context.ProductUploads.ToList();
                };

                dataGridView1.DataSource = Coll_Data;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

             private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.filter = "all files(*.*)|*.*";
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pbbrowse.ImageLocation = imglocation;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPId.Clear();
            txtPName.Clear();
            pbbrowse.ImageLocation = null;
        }
    }
}






