using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interation7And8
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);
        string Name {get; }
    }
}
