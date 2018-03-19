﻿using System;Resultdate
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public class Result
    {
        private DateTime resultdate;
        private TimeSpan lapTime;

        public DateTime Resultdate { get => resultdate; private set => resultdate = value; }
        public TimeSpan LapTime { get => lapTime; private set => lapTime = value; }

        public Result( DateTime resultdate, TimeSpan lapTime)
        {
            Resultdate = resultdate;
            LapTime = lapTime;
        }
    }
}
