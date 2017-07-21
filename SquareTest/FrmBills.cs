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
    public partial class FrmBills : MaterialForm
    {
        Bill billObject = new Bill();
        Customer customerObject = new Customer();
        List<Bill> data = new List<Bill>();
        public FrmBills()
        {
            InitializeComponent();           
        }


        private void FrmBills_Load(object sender, EventArgs e)
        {
            data = billObject.getItems();
            dataGridView1.DataSource = data;
            txtSearch.Hint = "Search";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Bill> filterdData = new List<Bill>();
                foreach (var bill in data)
                {
                    if (
                        bill.Id.ToString().Contains(txtSearch.Text)// ||
                      //  new Customer().getCustomerNameById(bill.UId).Contains(txtSearch.Text)
                        )
                        filterdData.Add(bill);                        
                }                
                dataGridView1.DataSource = filterdData;
            }catch (Exception) {}
        }       
    }
}