using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin
{
    public class Discipline
    {
        private int disciplineNum;
        private string name;

        public int DisciplineNum { get => disciplineNum; private set => disciplineNum = value; }
        public string Name { get => name; private set => name = value; }

        public Discipline(int disciplineNum ,string name)
        {
            DisciplineNum = disciplineNum;
            Name = name;
        }

        public void Top5Swimmers()
        {

        }
    }
}
