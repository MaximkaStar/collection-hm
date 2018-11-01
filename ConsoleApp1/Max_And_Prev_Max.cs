using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Max_And_Prev_Max
    {
        public int PREV_MAX { get; set; }
        public int MAX { get; set; }

        public Max_And_Prev_Max()
        {
            PREV_MAX = 0;
            MAX = 0;
        }
        public void SetMax(int Number)
        {
            PREV_MAX = MAX;
            MAX = Number;
        }
    }
}
