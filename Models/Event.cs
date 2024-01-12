using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Models
{
    public class Event
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string EventName { get; set; }
        public string Adress { get; set; }
        public string EventDetails
        {
            get
            {
                return EventName + " " + Adress;
            }
        }
        [OneToMany]
        public List<ShopList> ShopLists { get; set; }
    }
}
