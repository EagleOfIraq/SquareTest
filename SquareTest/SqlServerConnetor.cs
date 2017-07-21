using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.ServiceProcess;



namespace SquareTest
{
    public class SqlServerConnetor
    {
        public static string server { get; set; }
        public static string dataBase { get; set; }
        public static string service { get; set; } = "MSSQLSERVER";

        public SqlConnection con;
        SqlCommand command;
        public SqlServerConnetor()
        {            
            con = new SqlConnection();
            con.ConnectionString =
                  "Data Source=" + server + ";Initial Catalog=" + dataBase + ";Integrated Security=True";
            connect();
        }
        void connect()
        {
            checktServerStates();
            try
            {
                command = new SqlCommand();
                command.Connection = con;
                con.Open();
                con.Close();
            }
            catch (Exception)
            {
                var res = MessageBox.Show("SQL Database ERORR database "+dataBase+" is not fund ,Do you want to Create it ?!.",
                    "Erorr", MessageBoxButtons.YesNo);
                if (res.Equals(DialogResult.Yes))
                {
                    refrish();
                    connect();
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Bye");
                    //here I'm trying to restart the app cuz i need to start over from the scratch
                    //  new Form1().CloseApp(); //1
                    //  Application.Exit(); //2
                    //   new Form1(); //3

                    // none of them works :'(
                }
            }
        }
        public void excuteQuery(string query)
        {
            command.CommandText = query;
            
            try
            {
                con.Open();
                command.ExecuteNonQuery();
              //  MessageBox.Show("yeeey\n\r" + query); //say that it's works fine
            }
            catch (Exception e)
            {
                Clipboard.SetText(query);
                MessageBox.Show(e.Message + "\n\r" + query);
            }
            finally
            {
                con.Close();
            }
        }

        public void refrish()
        {
            con.ConnectionString =
                      "Data Source=" + server + ";Integrated Security=True";
            excuteQuery(
             "USE master;" +
             "DROP DATABASE IF EXISTS " + dataBase + ";" +
             "CREATE DATABASE " + dataBase + ";");
            excuteQuery(
             "USE " + dataBase + ";" +
             "DROP TABLE IF EXISTS items;" +
             "DROP TABLE IF EXISTS bill_items;" +
             "DROP TABLE IF EXISTS bills;" +
             "DROP TABLE IF EXISTS users;" +
             "DROP TABLE IF EXISTS customers;" +

            "create table items(id int not null identity(1, 1) primary key,item_name varchar(128),quantity int,sell_price int,buying_price int,image_url varchar(512),note varchar(512));" +

            "create table bill_items(id int not null identity(1, 1) primary key,b_id int,item_id int,sell_price int,quantity int);" +

            "create table bills(id int not null identity(1, 1) primary key,u_id int,c_id int,total_price int,note varchar(512), _date varchar(64));" +

            "create table users(id int not null identity(1, 1) primary key,user_name varchar(128),login_name varchar(128),user_password varchar(128));" +

            "create table customers(id int not null identity(1, 1) primary key,name varchar(128),address varchar(128),phone varchar(128));"
                );
            string targetPath = @"" + Directory.GetCurrentDirectory() + "\\images";
            if (Directory.Exists(targetPath))
            {
                Directory.Delete(targetPath, true);
            }
            
        }
        public SqlDataReader getData(string query)
        {
            con.Close();
            con.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public void checktServerStates()
        {
            ServiceController serviceController = new ServiceController(service);
            if (serviceController.Status.Equals(ServiceControllerStatus.Stopped)) {
            var res = MessageBox.Show("Server Status is : " + serviceController.Status.ToString() + " Do you want to start it ?! ",
                    "Erorr", MessageBoxButtons.YesNo);

            if (res.Equals(DialogResult.Yes))
                {
                    try
                    {
                        serviceController.Start();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Run tha Application as admin please.");
                        Application.Exit();
                    }
                }
            }

        }
    }
}
