using System;

namespace Dolphin
{
    public class Member
    {
        private int memberNum;
        private string name, adress, phoneNumber;
        private DateTime birthday, enrollDate;
        private bool isMember;
        private MembershipType membershipType;

        public int MemberNum { get => memberNum; private set => memberNum = value; }
        public string Name { get => name; private set => name = value; }
        public string Adress { get => adress; private set => adress = value; }
        public string PhoneNumber { get => phoneNumber; private set => phoneNumber = value; }
        public DateTime Birthday { get => birthday; private set => birthday = value; }
        public DateTime EnrollDate { get => enrollDate; private set => enrollDate = value; }
        public bool IsMember { get => isMember; private set => isMember = value; }
        public MembershipType MembershipType { get => membershipType; private set => membershipType = value; }
        

        public Member (int memberNum, string name, string adress, string phoneNumber, DateTime birthday, DateTime enrollDate, MembershipType type)
        {
            MemberNum = memberNum;
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
