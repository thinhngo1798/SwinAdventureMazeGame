using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interation7And8
{
    public class Bag : Item, IHaveInventory
    {
        private Inventory _inventory;

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id)) return this;

            if (Inventory.HasItem(id))
            {
                return Inventory.Fetch(id);
            }
            else
                return null;
        }
        public override string FullDescription
        {
            get
            {
                return "In the " + Name + "you can see" + Environment.NewLine +_inventory.ItemList;
            }
        }
        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
    }
}
