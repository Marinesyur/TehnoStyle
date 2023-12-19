using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TehnoStyle
{
    public class DB
    {
        private readonly SQLiteConnection conn;

        public DB(string path)
        {
            conn = new SQLiteConnection(path);
            conn.CreateTable<Order>();
        }

        public List<Order> GetOrders()
        {
            return conn.Table<Order>().ToList();
        }

        public int SaveOrder(Order order)
        {
            return conn.Insert(order);
        }

    }
}
