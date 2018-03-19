using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public class MembershipType
    {
        private int typeNum;
        private string typeName;

        public int TypeNum { get => typeNum; private set => typeNum = value; }
        public string TypeName { get => typeName; private set => typeName = value; }

        public MembershipType(int typeNum, string typeName)
        {
            TypeNum = typeNum;
            TypeName = typeName;
        }
    }
}
