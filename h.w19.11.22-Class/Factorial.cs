using System;
using System.Collections.Generic;
using System.Text;

namespace h.w19._11._22_Class
{
    internal class Factorial
    {

        public Factorial()
        {

        }
      public int Result(int n)
      {
            
            int fact = 1;
                for (int i = 1; i <=n; i++)
            {
               fact*=i;
            }
            return fact;
      }
        
        

    }
}
