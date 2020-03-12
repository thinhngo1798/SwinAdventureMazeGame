using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interation7And8
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory; // to manage the Player's items.
        private Location _currentlocation; // to know the player's current location.
        public Player(string name, string desc)
            : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
            _currentlocation = new Location(new string[]  {"Swinburne", "Default2" },"Univeristy of Swinburne", "Swinburne can turn 'knowing' into 'know how'");
            
            }
        
        public GameObject Locate(string id) // find a Game_Object around.
        {
            if (AreYou(id)) return this;
            else if (_inventory.HasItem(id))
                    return _inventory.Fetch(id);
            else
                    return Currentlocation.Locate(id);
            
        }
        public override string FullDescription
        {
            get
            {
                return "You are carrying: "+Environment.NewLine + _inventory.ItemList;
            }
        }
        public void GoToDestination(string PathId)
        {
            Path path = Currentlocation.GetPath(PathId);
            if (path != null)
                path.GoTo(this);
        }
        public Inventory Inventory { get => _inventory; }
        public Location Currentlocation { get => _currentlocation; set => _currentlocation = value; }
    }
}
