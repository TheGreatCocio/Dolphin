using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public class MembershipType
    {
        private string typeName;

        public string TypeName { get => typeName; set => typeName = value; }

        public MembershipType(string typeName)
        {
            TypeName = typeName;
        }
    }
}
