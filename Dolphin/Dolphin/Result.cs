using System;Resultdate
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public class Result
    {
        private int memberNum;
        private int disciplineNum;
        private DateTime resultdate;
        private TimeSpan lapTime;

        public int MemberNum { get => memberNum; private set => memberNum = value; }
        public int DisciplineNum { get => disciplineNum; private set => disciplineNum = value; }
        public DateTime Resultdate { get => resultdate; private set => resultdate = value; }
        public TimeSpan LapTime { get => lapTime; private set => lapTime = value; }

        public Result( int MemberNum, int DisciplineNum, DateTime resultdate, TimeSpan lapTime)
        {
            MemberNum = memberNum;
            DisciplineNum = disciplineNum;
            Resultdate = resultdate;
            LapTime = lapTime;
        }
    }
}
