﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    class Coach
    {
        private string name;
        private int coachNum;


        public string Name { get => name; private set => name = value; }
        public int CoachNum { get => coachNum; private set => coachNum = value; }

        public Coach(string name, int coachNum)
        {
            CoachNum = coachNum;
            Name = name;
        }

    }
}
