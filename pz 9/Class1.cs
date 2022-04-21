using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_2_9
{
    internal class Bancc
    {
        public int chet;
        public Bancc(int ppp)
        {
            chet = ppp;
        }
        public void sniat(int sum)
        {
            chet -= sum;
        }
        public void vnesti(int sum)
        {
            chet += sum;
        }
    }
}
