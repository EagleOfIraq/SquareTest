using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SquareTest
{
    public partial class frmSell : MaterialForm
    {
        public frmSell()
        {
            InitializeComponent();
        }

        List<Item> data = new Item().getItems();
        Bill billObject = new Bill();
        Item itemObject = new Item();
        User userObject = new User();
        Customer customeObject = new Customer();
        AutoCompleteStringCollection customesNames = new AutoCompleteStringCollection();

        private void frmSell_Load(object sender, EventArgs e)
        {
            lblBillNo.Text = (billObject.getLastId()+1).ToString("#00000000");
            txtAddress.Hint = "Address";
            txtPhone.Hint = "Phone";
            lblDate.Text = (DateTime.Now).ToString("g");
            txtCustomerName.Focus();

            foreach (var customer in customeObject.getItems())
            {
                customesNames.Add(customer.Name);
            }
            txtCustomerName.AutoCompleteCustomSource = customesNames;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var r = e.RowIndex;
                var c = e.ColumnIndex;
                if (c == 1)
                {
                    Item item = getItemByName(dataGridView1[c, r].Value.ToString());
                    dataGridView1[0, r].Value = item.Id;
                    dataGridView1[3, r].Value = item.SellPrice;
                    dataGridView1[c + 1, r].Selected = true;
                }
                else if (c == 2 || c == 3)
                {
                    dataGridView1[4, r].Value =
                        Convert.ToInt32(dataGridView1[2, r].Value)
                                            *
                        Convert.ToInt32(dataGridView1[3, r].Value)
                        ;
                }
                else if (c == 4)
                {
                    int totalPrice = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        totalPrice += Convert.ToInt32(row.Cells[4].Value);
                    }
                    lblTotalPrice.Text = totalPrice.ToString();
                }

            }
            catch (Exception) { }
        }
        Item getItemByName(string name)
        {
            Item item = new Item();
            foreach (var i in data)
            {
                string n1 = i.Name.Trim();
                string n2 = name.Trim();
                if (n1.Equals(n2))
                    item = i;
            }
            return item;
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                customeObject.add(
                    new Customer(
                        0,
                        txtCustomerName.Text,
                        txtAddress.Text,
                        txtPhone.Text
                    )
                );
            }
            billObject.add(
                new Bill(
                    userObject.getUserIdByName(lblBillNo.Text),
                    Form1.uId,
                    new Customer().getCustomerIdByName(txtCustomerName.Text),
                    Convert.ToInt32(lblTotalPrice.Text),
                    txtNote.Text,
                    (DateTime.Now).ToString("g")
                    )
                );
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    new BillItem().add(
                                new BillItem(0,
                                Convert.ToInt32(lblBillNo.Text),
                                itemObject.getItemIdByName(row.Cells[1].Value.ToString()),
                                Convert.ToInt32(row.Cells[3].Value),
                                Convert.ToInt32(row.Cells[2].Value)
                         )
                    );
                    itemObject.decQuantity(itemObject.getItemIdByName(row.Cells[1].Value.ToString()),
                        Convert.ToInt32(row.Cells[2].Value));
                }
                catch (Exception) { }
            }
            this.Hide();
        }
        bool flag = false;
        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            foreach (var name in customesNames)
            {
                if (txtCustomerName.Text.Equals(name.ToString()))
                {
                    flag = true;
                    break;
                }
                else
                    flag = false;
            }
            if (flag)
            {
                txtAddress.Hide();
                txtPhone.Hide();
            }
            else
            {
                txtAddress.Visible = true;
                txtPhone.Visible = true;
            }            
        }
    }
}