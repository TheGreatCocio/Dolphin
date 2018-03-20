using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public class Transaction
    {
        private int memberNum;
        private DateTime transDate;
        private float amount;
        private char type;

        public int MemberNum { get => memberNum; private set => memberNum = value; }
        public DateTime TransDate { get => transDate; private set => transDate = value; }
        public float Amount { get => amount; private set => amount = value; }
        public char Type { get => type; private set => type = value; }

        public Transaction(int memberNum, DateTime transDate, float amount, char type)
        {
            MemberNum = memberNum;
            TransDate = transDate;
            Amount = amount;
            Type = type;
        }
    }
}
