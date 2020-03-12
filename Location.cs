using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interation7And8 
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory _inventory; // to manage the Player's items.
        private List<Path> _paths;
        private List<Player> _playerList;
        public List<Path> Paths { get => _paths; set => _paths = value; }
        public Location(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
            Paths = new List<Path>();
            PlayerList = new List<Player>();
            
        }

        public Inventory Inventory { get => _inventory; }

        public GameObject Locate(string id) // find a Game_Object around.
        {
            if (AreYou(id)) return this;
            else return Inventory.Fetch(id);
        }
        public void Put(Player player)
        {
            player.Currentlocation = this;
            PlayerList.Add(player);
        }
        public void RemovePlayer(Player player)
        {
            PlayerList.Remove(player);
        }
        public void Put(Item item)
        {
            Inventory.Put(item);
        }
        public override string FullDescription
        {
            get
            {
                return String.Format("In the {0} you can see: ", Name) + _inventory.ItemList;
            } 
        }

        public List<Player> PlayerList { get => _playerList; set => _playerList = value; }

        public void Put(Path path)
        {
            Paths.Add(path);
        }
        public bool HasPath(string id)
        {
            foreach (Path path in Paths)
            {
                if (path.AreYou(id))
                    return true;
            }
            return false;
        }
        public Path GetPath(string id)
        {
            foreach (Path path in Paths)
            {
                if (path.AreYou(id))
                    return path;
            }
            return null;
        }

    }
}
