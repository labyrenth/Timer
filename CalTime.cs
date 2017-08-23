using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TIMER
{
    class CalTime
    {
        public void GetTimer(ref int Hour, ref int Minute, ref int Second)
        {
            if (Second >= 60)
            {
                Second -= 60;
                Minute++;
            }
            if (Minute >= 60)
            {
                Minute -= 60;
                Hour++;
            }

        }
    }
}
