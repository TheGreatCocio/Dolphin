using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public class Elite : Member
    {
        private int coachNum;

        public int CoachNum { get => coachNum; private set => coachNum = value; }

        public Elite(int memberNum, string name, string adress, string phoneNumber, DateTime birthday, DateTime enrollDate, MembershipType type) : base(memberNum, name, adress, phoneNumber, birthday, enrollDate, type)
        {

        }

        public void ChangeCoach()
        {

        }

        public void TrainingResult()
        {

        }
        
    }
}
