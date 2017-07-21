using System.Collections.Generic;
using System.Data.SqlClient;
using System;
namespace SquareTest
{
    class Bill
    {
        int id;
        int uId { get; set; }
        int cId { get; set; }
        string userName;
        string customerName;
        int totalPrice;
        string note;
        string date;
      
        SqlServerConnetor sqlServerObject = new SqlServerConnetor();

        public Bill(int id, int uId, int cId, int totalPrice, string note, string date)
         {
             this.id = id;
             this.uId = uId;
             this.cId = cId;
             this.totalPrice = totalPrice;
             this.note = note;
             this.Date = date;
        }

        public Bill(int id, string userName, string customerName , int totalPrice, string note, string date)
        {
            this.id = id;
            this.userName = userName;
            this.customerName = customerName;
            this.totalPrice = totalPrice;
            this.note = note;
            this.Date = date;
        }

        public Bill(int id)
        {
            this.id = id;
        }

        public Bill(){}

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        /*
                public int UId
                {
                    get
                    {
                        return uId;
                    }

                    set
                    {
                        uId = value;
                    }
                }

                public int CId
                {
                    get
                    {
                        return cId;
                    }

                    set
                    {
                        cId = value;
                    }
                }
                */
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public int TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
            }
        }

        public string Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public void add(Bill bill)
        {
            sqlServerObject.excuteQuery(
                "INSERT INTO bills VALUES (" +
                bill.uId + "," +
                bill.cId + "," +
                bill.TotalPrice + ",'" +
                bill.Note + "','" +
                bill.Date + "')"
                );
        }

        public void edit(Bill bill)
        {
            sqlServerObject.excuteQuery(
                "UPDATE bills SET " +
                "u_id=" + bill.UserName + "," +
                "c_id=" + bill.CustomerName + "," +
                "total_price=" + bill.TotalPrice + "," +                
                "note='" + bill.Note + "'" +
                " WHERE id=" + bill.Id
                );
        }

        public void delete(Bill bill)
        {
            sqlServerObject.excuteQuery(
                "DELETE FROM bills WHERE id=" + bill.Id
                );
        }

        public List<Bill> getItems()
        {
            List<Bill> data = new List<Bill>();
            SqlDataReader reader = sqlServerObject.getData(
                "SELECT customers.id, users.user_name , customers.name, total_price, note ,_date FROM bills JOIN customers ON bills.c_id = customers.id JOIN users ON bills.u_id = users.id;"
                );
            while (reader.Read())
            {
             //   try
                {
                    int rId = reader.GetInt32(0);
                    string rN1 = reader.GetString(1);
                    string rN2 = reader.GetString(2);
                    int rprice = reader.GetInt32(3);
                    string rN3 = reader.GetString(4);
                    string dt = reader.GetString(5);
                    data.Add(new Bill(
                        rId, rN1, rN2, rprice, rN3, dt
                        ));
                }
                //catch { }
                /*data.Add(new Bill(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetInt32(3),
                    reader.GetString(4),
                    reader.GetDateTime(4)
                    ));*/
            }
            sqlServerObject.con.Close();
            return data;
        }

        public int getLastId()
        {
            int id=0;
            SqlDataReader reader = sqlServerObject.getData("SELECT TOP 1 * FROM bills ORDER BY id DESC");
            if (reader.Read())
            {
                id = reader.GetInt32(0);                    
            }
            sqlServerObject.con.Close();
            return id;
        }
    }
}