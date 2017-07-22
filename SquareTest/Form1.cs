using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SquareTest
{
    public partial class Form1 : MaterialForm
    {
        List<User> users;
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            var materialSkinManagerHome = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.Blue200,
                TextShade.BLACK
                );
            foreach (var form in Controls)
            {
                if (form.GetType().Equals(typeof(MaterialForm)))
                {
                    MaterialForm frm = (MaterialForm)form;
                    materialSkinManager.AddFormToManage(frm);
                    frm.WindowState = FormWindowState.Maximized;
                }
            }
         
            SqlServerConnetor.server = "EAGLE-PC";
            SqlServerConnetor.dataBase = "SquareTestDB";
            SqlServerConnetor.service = "MSSQLSERVER";
        }
        User userObject = new User();
        private void Form1_Load(object sender, EventArgs e)
        {
            users = userObject.getItems();

            if (users.Count<1)
            {
                userObject.add(new User(0, "Admin", "Admin", "Admin"));
                users = userObject.getItems();
                MessageBox.Show(users.Count + " s");
            }
        }
        public void CloseApp()
        {
            this.Close();
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            new frmSell().Show();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            new FrmBills().Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            new frmItems().Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            new FrmUsers().Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            new frmCustomers().Show();
        }
        public static int uId;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool flag = false;

            foreach (var user in users)
            {
                if (
                    user.LoginName.Equals(materialSingleLineTextField1.Text) &&
                    user.Password.Equals(materialSingleLineTextField2.Text)
                    )
                {
                    flag = true;
                    uId = user.Id;
                    break;
                }
            }
            if (flag)
            {
                panelMain.Visible = true;
                //panelLogin.Visible = false;
            }
        }
    }
}
