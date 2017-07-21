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
    public partial class frmCustomers : MaterialForm
    {
        List<Customer> data;
        Customer customerObject = new Customer();
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            data = customerObject.getItems();
            dataGridView1.DataSource = data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            customerObject.add(
               new Customer(
                     0,
                     txtCustomerName.Text,
                     txtAddress.Text,
                     txtPhone.Text
                   )
               );
            data = customerObject.getItems();
            dataGridView1.DataSource = data;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Customer> filterdData = new List<Customer>();
                foreach (var customer in data)
                {
                    if (
                        customer.Name.ToLower().Contains(txtSearch.Text.ToLower()) ||
                        customer.Address.ToLower().Contains(txtSearch.Text.ToLower()) ||
                        customer.Phone.ToLower().Contains(txtSearch.Text.ToLower())
                        )
                        filterdData.Add(customer);
                }
                dataGridView1.DataSource = filterdData;
            }
            catch (Exception) { }
        }
        Boolean editOrSave = false;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var r = dataGridView1.SelectedRows[0].Index;
            var id = Convert.ToInt32(dataGridView1[0, r].Value);
            if (!editOrSave)
            {
                txtCustomerName.Text = dataGridView1[1, r].Value.ToString();
                txtAddress.Text = dataGridView1[2, r].Value.ToString();
                txtPhone.Text = dataGridView1[3, r].Value.ToString();
                editOrSave = true;
                btnEdit.Text = "Save";
            }
            else
            {
                var res = MessageBox.Show(
                    "Edit " + dataGridView1[1, r].Value.ToString() + " to " + txtCustomerName.Text + " ?!.",
                    "Edit!!",
                    MessageBoxButtons.YesNo
                    );
                if (res.Equals(DialogResult.Yes))
                {
                    customerObject.edit(new Customer(
                        id,
                        txtCustomerName.Text,
                        txtAddress.Text,
                        txtPhone.Text
                        )
                    );
                }
                data = customerObject.getItems();
                dataGridView1.DataSource = data;
                editOrSave = false;
                txtCustomerName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                btnEdit.Text = "Edit";
            }
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
                customerObject.delete(new Customer(id));
                data = customerObject.getItems();
                dataGridView1.DataSource = data;
            }
        }
    }
}