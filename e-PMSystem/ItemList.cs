using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaterialManagement
{
    public class ItemList
    {
        public string itemName;
        public int amount;
        public string type;
        public string dt;
        public string storage;


        public ItemList(string itemName, int amount, string type, string dt, string storage)
        {
            this.itemName = itemName;
            this.amount = amount;
            this.type = type;
            this.dt = dt;
            this.storage = storage;
        }
    }
}
