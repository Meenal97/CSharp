using System;
using System.Collections.Generic;
using System.Text;

namespace Name
{
    class EvenNumbers
    {
        public void Even()
        {
            int start = 0;
            while(start <= 20)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }

        public static void EvenNumber(int end)
        {
            int start = 0;
            while (start <= end)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
    }
}
