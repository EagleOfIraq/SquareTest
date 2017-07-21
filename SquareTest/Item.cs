using System.Collections.Generic;
using System.Data.SqlClient;

namespace SquareTest
{
    public class Item
    {
        int id;
        string name;
        int quantity;
        int sellPrice;
        int buyingPrice;
        string imageUrl;
        string note;

        SqlServerConnetor sqlServerObject = new SqlServerConnetor();

        public Item(int id, string name, int quantity, int sellPrice, int buyingPrice, string imageUrl, string note)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.sellPrice = sellPrice;
            this.buyingPrice = buyingPrice;
            this.imageUrl = imageUrl;
            this.note = note;
        }

        public Item(int id)
        {
            this.id = id;
        }

        public Item() { }

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

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public int SellPrice
        {
            get
            {
                return sellPrice;
            }

            set
            {
                sellPrice = value;
            }
        }

        public int BuyingPrice
        {
            get
            {
                return buyingPrice;
            }

            set
            {
                buyingPrice = value;
            }
        }

        public string ImageUrl
        {
            get
            {
                return imageUrl;
            }

            set
            {
                imageUrl = value;
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

        public void add(Item item)
        {
            sqlServerObject.excuteQuery(
                "INSERT INTO items VALUES ('" +
                item.Name + "'," +
                item.Quantity + "," +
                item.SellPrice + "," +
                item.BuyingPrice + ",'" +
                item.ImageUrl + "','" +
                item.Note + "')"
                );
        }

        public void edit(Item item)
        {
            sqlServerObject.excuteQuery(
                "UPDATE items SET "+ 
                "item_name='"+ item.Name +"',"+
                "quantity="+ item.Quantity +"," +
                "sell_price=" + item.SellPrice + "," +
                "buying_price=" + item.BuyingPrice + "," +
                "image_url='" + item.ImageUrl + "'," +
                "note='" + item.Note + "'" +
                " WHERE id=" + item.Id
                );
        }

        public void delete(Item item)
        {
            sqlServerObject.excuteQuery(
                "DELETE FROM items WHERE id=" + item.Id
                );
        }

        public List<Item> getItems()
        {
            List<Item> data=new List<Item>();
            SqlDataReader reader = sqlServerObject.getData(
                "SELECT * FROM items"              
                );
            while (reader.Read())
            {
                data.Add(new Item(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3),
                    reader.GetInt32(4),
                    reader.GetString(5),
                    reader.GetString(6)
                    ));
            }
            sqlServerObject.con.Close();
            return data;
        }

        public int getItemIdByName(string name)
        {
            int id = 0;
            SqlDataReader reader = sqlServerObject.getData("SELECT id FROM items WHERE item_name='" + name+"';");
            if (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            sqlServerObject.con.Close();
            return id;
        }

        public void decQuantity(int id,int decVaue)
        {
            sqlServerObject.excuteQuery(
               "UPDATE items SET " +
               "quantity=quantity-" + decVaue +            
               " WHERE id=" + id
               );
        }
        public string toString()
        {
            return
                "Item : \n\r" +
                "Name : " + Name + " \n\r" +
                "Quantity : " + Quantity + " \n\r" +
                "Sell Price : " + SellPrice + " \n\r" +
                "Buying Price : " + BuyingPrice + " \n\r" +
                "Image Url : " + ImageUrl + " \n\r" +
                "Note : " + Note;
        }
    }
}