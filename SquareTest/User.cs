using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareTest
{
    class User
    {
        int id;
        string userName;
        string loginName;
        string password;

        SqlServerConnetor sqlServerObject = new SqlServerConnetor();

        public User(int id, string userName, string loginName, string password)
        {
            this.id = id;
            this.userName = userName;
            this.loginName = loginName;
            this.password = password;
        }

        public User(int id)
        {
            this.id = id;
        }

        public User(){}

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

        public string LoginName
        {
            get
            {
                return loginName;
            }

            set
            {
                loginName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public void add(User user)
        {
            sqlServerObject.excuteQuery(
                "INSERT INTO users VALUES ('" +
                user.UserName + "','" +
                user.LoginName + "','" +
                user.Password + "')"
                );
        }

        public void edit(User user)
        {
            sqlServerObject.excuteQuery(
                "UPDATE users SET " +
                "user_name='" + user.UserName + "'," +
                "login_name='" + user.LoginName + "'," +
                "user_password='" + user.Password + "'" +
                " WHERE id=" + user.Id
                );
        }

        public void delete(User user)
        {
            sqlServerObject.excuteQuery(
                "DELETE FROM users WHERE id=" + user.Id
                );
        }

        public List<User> getItems()
        {
            List<User> data = new List<User>();
            SqlDataReader reader = sqlServerObject.getData(
                "SELECT * FROM users"
                );
            while (reader.Read())
            {
                data.Add(new User(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)                   
                    ));
            }
            sqlServerObject.con.Close();
            return data;
        }

        public int getUserIdByName(string name)
        {
            int id = 0;
            SqlDataReader reader = sqlServerObject.getData("SELECT id FROM users WHERE user_name='" + name + "';");
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            sqlServerObject.con.Close();
            return id;
        }
    }
}
