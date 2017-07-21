using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareTest
{
    class BillItem
    {
        int id ;
        int bId ;
        int bItemId ;
        int sellPrice ;
        int quantity ;

        SqlServerConnetor sqlServerObject = new SqlServerConnetor();

        public BillItem(int id, int bId, int bItemId, int sellPrice, int quantity)
        {
            this.Id = id;
            this.BId = bId;
            this.BItemId = bItemId;
            this.SellPrice = sellPrice;
            this.Quantity = quantity;
        }

        public BillItem(int id)
        {
            this.id = id;
        }
        public BillItem(){}

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

        public int BId
        {
            get
            {
                return bId;
            }

            set
            {
                bId = value;
            }
        }

        public int BItemId
        {
            get
            {
                return bItemId;
            }

            set
            {
                bItemId = value;
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


        public void add(BillItem billtem)
        {
            sqlServerObject.excuteQuery(
                "INSERT INTO bill_items VALUES (" +
                billtem.BId + "," +
                billtem.BItemId + "," +
                billtem.SellPrice + "," +
                billtem.Quantity + ")"
                );
        }
    }
}