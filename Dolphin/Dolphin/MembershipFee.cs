using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public class MembershipFee
    {
        private string typeName;
        private float fee;

        public string TypeName { get => typeName; private  set => typeName = value; }
        public float Fee { get => fee; private set => fee = value; }

        public MembershipFee(string typeName, float fee)
        {
            TypeName = typeName;
            Fee = fee;
        }
    }
}
