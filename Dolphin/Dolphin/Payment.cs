using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public class Payment
    {
        private DateTime date;
        private float amount, credit;

        public DateTime Date { get => date; set => date = value; }
        public float Amount { get => amount; set => amount = value; }
        public float Credit { get => credit; set => credit = value; }

        public Payment(DateTime date, float amount, float credit)
        {
            Date = date;
            Amount = amount;
            Credit = credit;
        }
    }
}
