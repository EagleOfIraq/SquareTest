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
    public partial class FrmReport : MaterialForm
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SquareTestDBDataSet1.items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.SquareTestDBDataSet1.items);

            this.reportViewer1.RefreshReport();
        }
    }
}
