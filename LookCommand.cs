using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interation7And8
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] {"look"})
        {}

        public override string Execute(Player p, string[] text)
        {
            IHaveInventory Container=null;
            string ItemId=null;
            string ContainerId = null;
            int TextLength = text.Length;
            // The length of the text is either 3 or 5.
            if ((TextLength!=3) && (TextLength!=5) && (TextLength!=1))
            {
                return "I dont know how to look like that";
            }
            //Look at the location of the player
            if ((text[0]=="look")&&(text.Length==1))
            {
                return p.Currentlocation.FullDescription;
            }
            //The first word must be "look".
            if(text[0]!="look")
            {
                return "Error in look input";
            }
            //The second word must be "at".
            if (text[1] != "at")
            {
                return "What do you want to look at?";
            }
            //If the text has 3 words, the container must be player p.
            if (TextLength == 3)
            {
                ContainerId = p.Name;
                Container = p as IHaveInventory;
            }
            //If the length of text is 5, the fourth word must be "in".
            if (TextLength==5)
            {
                if (text[3] == "in")
                {
                    ContainerId = text[4];
                    Container = FetchContainer(p, ContainerId);
                }
                else
                    return "What do you want to look in?";
            }
            //The third word must be the ItemId
            ItemId = text[2];

            if (Container == null)
                return "I cannot find the " + ContainerId;

            if (Container.Locate(ItemId) == null)
                return "I cannot find the " + ItemId + " in the " + ContainerId;
            
            return LookAtIn(ItemId, Container);


        }
        private IHaveInventory FetchContainer(Player p, string containerId)
        {
                return p.Locate(containerId) as IHaveInventory;


        }
        private string LookAtIn (string thingId,IHaveInventory container)
        {
            GameObject obj = container.Locate(thingId);
            if (obj != null)
            {
                return obj.FullDescription;
            }
            else
            {
                string result = "I cannot find the " + thingId + " in the " + container.Name;
                return result;
            }
            

        }
    }
}
