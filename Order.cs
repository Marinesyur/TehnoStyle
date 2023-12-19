using System;
using SQLite;

namespace TehnoStyle
{
    public class Order
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int OrderType { get; set; }
        public int ProductModel { get; set; }
        public string Comments { get; set; }
        public DateTime MeasurementDate { get; set; }
        
    }

}

