using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBased_RTS.Business_Layer
{
    internal class Water : Resource
    {
        public override string getType()
        {
            return "Water";
        }
    }
}
