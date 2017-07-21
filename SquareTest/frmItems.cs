using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareTest
{
    public partial class frmItems : MaterialForm
    {
        public frmItems()
        {
            InitializeComponent();
            txtItemName.Hint = "Name";
            txtItemBuyingPrice.Hint = "BuyingPrice";
            txtItemNote.Hint = "Note";
            txtItemSellPrice.Hint = "SellPrice";
            txtItemQuantity.Hint = "Quantity";
        }

        Item itemObject=new Item();
       
        List<Item> data;     

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            var r = dataGridView1.SelectedRows[0].Index;
            var c= 0;
            var id =Convert.ToInt32(dataGridView1[c,r].Value);
            var res = MessageBox.Show(
                "Delete "+ dataGridView1[c+1, r].Value.ToString()+" ?.",
                "DELETE!!",
                MessageBoxButtons.YesNo
                );
            if (res.ToString().Equals(DialogResult.Yes.ToString()))
            {
                itemObject.delete(new Item(id));
                string imageUrl = @"" + dataGridView1[5, r].Value.ToString();
                if(File.Exists(imageUrl))
                    File.Delete(imageUrl);
                data = new Item().getItems();
                dataGridView1.DataSource = data;
            }
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {        
        List<Item> fillterdData = new List<Item>();
            foreach (var item in data)
            {
                if (
                        item.Name.ToLower().Contains(txtSearch.Text.ToLower()) ||
                        item.Id.ToString().ToLower().Contains(txtSearch.Text.ToLower())
                    )
                    fillterdData.Add(item);
            }
               dataGridView1.DataSource = fillterdData;
        }
        
        string imageLocation;
        private void btnItemImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog getFile = new OpenFileDialog();
            getFile.ShowDialog();
            imageLocation = getFile.FileName;
            pictureBox1.ImageLocation = @"" + imageLocation;
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var r = dataGridView1.SelectedRows[0].Index;
                var c = 5;
                var url = dataGridView1[c, r].Value.ToString();
                pictureBox1.ImageLocation = @"" + url;

            }
            catch (Exception )
            {

            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            new FrmReport().Show();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            data = itemObject.getItems();
            dataGridView1.DataSource = data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string fileName = txtItemName.Text;
            string sourcePath = @"" + imageLocation;
            string targetPath = @"" + Directory.GetCurrentDirectory() + "\\images";

            string sourceFile = sourcePath;
            string destFile = Path.Combine(targetPath, fileName);

            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            File.Copy(sourceFile, destFile, true);

            itemObject.add(
                new Item(
                0,
                txtItemName.Text,
                Convert.ToInt32(txtItemQuantity.Text),
                Convert.ToInt32(txtItemSellPrice.Text),
                Convert.ToInt32(txtItemBuyingPrice.Text),
                destFile,
                txtItemNote.Text
                )
            );
            data = itemObject.getItems();
            dataGridView1.DataSource = data;
            txtItemName.Text = "";
            txtItemQuantity.Text = "";
            txtItemSellPrice.Text = "";
            txtItemBuyingPrice.Text = "";
            txtItemNote.Text = "";
        }
        Boolean editOrSave = false;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var r = dataGridView1.SelectedRows[0].Index;
            var id = Convert.ToInt32(dataGridView1[0, r].Value);
            if (!editOrSave)
            {
                txtItemName .Text = dataGridView1[1, r].Value.ToString();
                txtItemQuantity.Text = dataGridView1[2, r].Value.ToString();
                txtItemSellPrice.Text = dataGridView1[3, r].Value.ToString();
                txtItemBuyingPrice.Text = dataGridView1[4, r].Value.ToString();
                txtItemNote.Text = dataGridView1[6, r].Value.ToString();
                editOrSave = true;
                btnEdit.Text = "Save";
            }
            else
            {
                var res = MessageBox.Show(
                    "Edit " + dataGridView1[1, r].Value.ToString() + " to " + txtItemName.Text + " ?!.",
                    "Edit!!",
                    MessageBoxButtons.YesNo
                    );
                if (res.Equals(DialogResult.Yes))
                {
                    string fileName = txtItemName.Text;
                    string sourcePath = @"" + imageLocation;
                    string targetPath = @"" + Directory.GetCurrentDirectory() + "\\images";

                    string sourceFile = sourcePath;
                    string destFile = Path.Combine(targetPath, fileName);

                    if (!Directory.Exists(targetPath))
                    {
                        Directory.CreateDirectory(targetPath);
                    }

                    File.Copy(sourceFile, destFile, true);

                    itemObject.edit(
                       new Item(
                               0,
                            txtItemName.Text,
                            Convert.ToInt32(txtItemQuantity.Text),
                            Convert.ToInt32(txtItemSellPrice.Text),
                            Convert.ToInt32(txtItemBuyingPrice.Text),
                            destFile,
                            txtItemNote.Text
                       )
                    );
                }
                data = itemObject.getItems();
                dataGridView1.DataSource = data;
                editOrSave = false;
                txtItemName.Text = "";
                txtItemQuantity.Text = "";
                txtItemSellPrice.Text = "";
                txtItemBuyingPrice.Text = "";
                txtItemNote.Text = "";
                btnEdit.Text = "Edit";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            editOrSave = false;
            txtItemName.Text = "";
            txtItemQuantity.Text = "";
            txtItemSellPrice.Text = "";
            txtItemBuyingPrice.Text = "";
            txtItemNote.Text = "";
            btnEdit.Text = "Edit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = dataGridView1.SelectedRows[0].Index;
            var c = 0;
            var id = Convert.ToInt32(dataGridView1[c, r].Value);
            itemObject.delete(
                new Item(id)
                );
            data = itemObject.getItems();
            dataGridView1.DataSource = data;
        }     
    }
}
