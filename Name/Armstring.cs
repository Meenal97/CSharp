
using System;
using System.Collections.Generic;
using System.Text;

namespace Name
{
    class Armstring
    {

        int rem,sum  = 0;
        public bool ArmstongOrnot(int num)
        {
            int number;
            number = num;
            while(num > 0)
            {
                rem = num % 10;
                sum += rem * rem * rem;
                num = num / 10;
            }
            return number == sum ? true : false;
        
        }

    }
}
