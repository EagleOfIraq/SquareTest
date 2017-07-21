using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareTest
{
    public partial class FrmUsers : MaterialForm
    {
        List<User> data;
        User userObject = new User();
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            data = userObject.getItems();
            dataGridView1.DataSource = data;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<User> filterdData = new List<User>();
                foreach (var user in data)
                {
                    if (
                        user.UserName .ToLower().Contains(txtSearch.Text.ToLower()) ||
                        user.LoginName.ToLower().Contains(txtSearch.Text.ToLower())
                        )
                        filterdData.Add(user);
                }
                dataGridView1.DataSource = filterdData;
            }
            catch (Exception) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            userObject.add(
                new User(
                      0,
                      txtUserrName.Text,
                      txtLoginName.Text,
                      txtPassword.Text
                    )
                );
            data = userObject.getItems();
            dataGridView1.DataSource = data;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            var r = dataGridView1.SelectedRows[0].Index;
            var c = 0;
            var id = Convert.ToInt32(dataGridView1[c, r].Value);
            var res = MessageBox.Show(
                "Delete " + dataGridView1[c + 1, r].Value.ToString() + " ?.",
                "DELETE!!",
                MessageBoxButtons.YesNo
                );
            if (res.Equals(DialogResult.Yes))
            {
                userObject.delete(new User(id));                
                data = userObject.getItems();
                dataGridView1.DataSource = data;
            }
        }

        Boolean editOrSave = false;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var r = dataGridView1.SelectedRows[0].Index;
            var id = Convert.ToInt32(dataGridView1[0, r].Value);
            if (!editOrSave)
            {
                txtUserrName.Text = dataGridView1[1, r].Value.ToString();
                txtLoginName.Text = dataGridView1[2, r].Value.ToString();
                txtPassword.Text = dataGridView1[3, r].Value.ToString();
                editOrSave = true;
                btnEdit.Text = "Save";
            }
            else
            {
                var res = MessageBox.Show(
                    "Edit " + dataGridView1[1, r].Value.ToString() + " to " + txtUserrName.Text + " ?!.",
                    "Edit!!",
                    MessageBoxButtons.YesNo
                    );
                if (res.Equals(DialogResult.Yes))
                {
                    userObject.edit(new User(
                        id,
                        txtUserrName.Text,
                        txtLoginName.Text,
                        txtPassword.Text
                        )
                    );
                }
                data = userObject.getItems();
                dataGridView1.DataSource = data;
                editOrSave = false;
                txtUserrName.Text = "";
                txtLoginName.Text = "";
                txtPassword.Text = "";
                btnEdit.Text = "Edit";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            editOrSave = false;
            txtUserrName.Text = "";
            txtLoginName.Text = "";
            txtPassword.Text = "";
            btnEdit.Text = "Edit";
        }
    }
}
