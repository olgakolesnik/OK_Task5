using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OK_Task5
{
    class Task
    {
        public string Name;
        public int Priority;
        public int Complexity;
        public int Time;


        public void setComplexity(int compl)
        {
            this.Complexity = compl;
            if (compl == 1) this.Time = 4;
            else
                if (compl == 2) this.Time = 2;
            else
                if (compl == 3) this.Time = 1;
        }
    }
}
