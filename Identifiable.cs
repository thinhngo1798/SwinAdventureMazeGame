using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interation7And8
{
    public  abstract class IdentifiableObject
    {
        private List<string> _identifiers = new List<string>();
        
        public IdentifiableObject(string[] idents)
        {
            foreach (string item in idents)
            {
                AddIdentifier(item);
            }
        }
        public bool AreYou(string id)
        {   foreach (string s in _identifiers)
            {
                if (s == id.ToLower())
                    return true;
            }
            return false;

        }
        public string FirstId
        { 
            get
            {
                return (_identifiers.Count > 0) ? _identifiers[0] : "It is an empty list";
               
            }
        }
        public void AddIdentifier (string id)
        {
            _identifiers.Add(id.ToLower());

        }
    }
}
