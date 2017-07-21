using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SquareTest
{
    class Customer
    {
        int id;
        string name;
        string address;
        string phone;

        SqlServerConnetor sqlServerObject = new SqlServerConnetor();

        public Customer(int id, string name, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public Customer(int id)
        {
            this.id = id;
        }
        public Customer(){}

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public void add(Customer customer)
        {
            sqlServerObject.excuteQuery(
                "INSERT INTO customers VALUES ('" +
                customer.Name + "','" +
                customer.Address + "','" +
                customer.Phone + "')"
                );
        }

        public void edit(Customer customer)
        {
            sqlServerObject.excuteQuery(
                "UPDATE customers SET " +
                "name='" + customer.Name + "'," +
                "address='" + customer.Address + "'," +
                "phone='" + customer.Phone + "'" +
                " WHERE id=" + customer.Id
                );
        }

        public void delete(Customer customer)
        {
            sqlServerObject.excuteQuery(
                "DELETE FROM customers WHERE id=" + customer.Id
                );
        }
    
        public List<Customer> getItems()
        {
            List<Customer> data = new List<Customer>();
            SqlDataReader reader = sqlServerObject.getData(
                "SELECT * FROM customers"
                );
            while (reader.Read())
            {
                data.Add(new Customer(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                    ));
            }
            sqlServerObject.con.Close();
            return data;
        }

        public int getCustomerIdByName(string name)
        {
            int id = 0;
            SqlDataReader reader = sqlServerObject.getData("SELECT id FROM customers WHERE name='" + name + "';");
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            sqlServerObject.con.Close();
            return id;
        }

        public string getCustomerNameById(int id)
        {
            string name="";
            SqlDataReader reader = sqlServerObject.getData("SELECT name FROM customers WHERE id=" + id + ";");
            if (reader.Read())
            {
                name = reader.GetString(0);
            }
            sqlServerObject.con.Close();
            return name;
        }

    }
}