using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    class CRUDController
    {
        public CRUDController()
        {
        }
        private static CRUDController instance;

        public static CRUDController Instance
        {
            get
            {
                if (instance == null)
                { instance = new CRUDController(); }
                return instance;
            }
        }

        public bool CreateMember(string name, string adress, string phoneNumber, DateTime birthday)
        {
            Member member = new Member(null, name, adress, phoneNumber, birthday, DateTime.Now, new MembershipType("Active"));
            return DAL.Instance.CreateMember(member);
        }
    }
}
