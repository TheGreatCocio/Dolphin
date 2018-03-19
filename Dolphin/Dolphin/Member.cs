using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public class Member
    {
        private string name, adress, phoneNumber;
        private DateTime birthday, enrollDate;
        private MembershipType membershipType;

        public string Name { get => name; set => name = value; }
        public string Adress { get => adress; set => adress = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public DateTime EnrollDate { get => enrollDate; set => enrollDate = value; }
        public MembershipType MembershipType { get => membershipType; set => membershipType = value; }

        public Member (string name, string adress, string phoneNumber, DateTime birthday, DateTime enrollDate, MembershipType type)
        {
            Name = name;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Birthday = birthday;
            EnrollDate = enrollDate;
            MembershipType = type;
        }

        public void ChangeMembership()
        {

        }
        
        public void ChangeElite()
        {

        }
    }
}
