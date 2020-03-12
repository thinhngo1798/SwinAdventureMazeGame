using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interation7And8
{
    public class Inventory
    {
        private List<Item> _item; 

        public string ItemList
        {
            get
            {
                string result = "";
                foreach (Item item in _item)
                {
                    result = result + item.ShortDescription + "\n";
                }
                return result; 
            }
        }

        public  Inventory()
        {
            _item = new List<Item>();
        }
        public bool HasItem(string id)
        {
            foreach(Item item in _item)
            {
                if (item.AreYou(id))
                     return true; 
            }
            return false;
        }
        public void Put(Item itm)
        {
            _item.Add(itm);
        }
        public Item Take(string id)
        {
            Item result;
            result = Fetch(id);
            _item.Remove(result);
            return result;
        }
        public Item Fetch(string id)
        {
            foreach (Item item in _item)
            {
                if (item.AreYou(id))
                {
                    return item;
                }
            }
            return null;
        }

    }
}
