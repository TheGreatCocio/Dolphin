using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public class Result
    {
        private DateTime date;
        private TimeSpan time;

        public DateTime Date { get => date; set => date = value; }
        public TimeSpan Time { get => time; set => time = value; }

        public Result( DateTime date, TimeSpan time)
        {
            Date = date;
            Time = time;
        }
    }
}
