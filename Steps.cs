using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectone
{
    public class Stepscal
    {
        public void StepsStar(int n)
        {
           for(int i=1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("#");
                }
                for (int k = i + 1; k <= n; k++)
                {
                    Console.Write(" ");
                }
                // Move to the next line for the next row
                Console.WriteLine();
            }
        }
    }
}
