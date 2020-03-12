using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interation7And8
{
   public class MoveCommand :Command
    {
        public MoveCommand() :base(new string[] { " move","go","head","leave"})
        { }
        public override string Execute(Player p, string[] text)
        {
            Path path;
            string PathId;
            int TextLength = text.Length;
            if (TextLength!=2)
            {
                return "I do not know how to move like that";
            }
            if (!AreYou(text[0]))
            {
                return "Invalid input";
            }
            PathId = text[1];
            path = p.Currentlocation.GetPath(PathId);
            if (path == null)
            {
                return " There is no path like this in the current location";
            }
            p.Currentlocation.RemovePlayer(p);
            p.Currentlocation = path.Destination;
            return "You head{path.Name}" + Environment.NewLine + p.Currentlocation.FullDescription;
            
        }
    }
}
