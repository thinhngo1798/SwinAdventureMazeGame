using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interation7And8
    {
    public class Path : GameObject
    {
        private Location _destination;

        public Location Destination { get => _destination; set => _destination = value; }

        public Path(string[] ids,string name,string description) : base(ids,name,description)
        {
            
        }
        public void GoTo(Player player)
        {
            player.Currentlocation = Destination;
        }
    }
}
