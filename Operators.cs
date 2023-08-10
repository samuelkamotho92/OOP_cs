using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectone
{
    public class Operators
    {
        //UNARY //BINARY //TERNARY
        public void Arithmetic(int a, int b)
        {
            Console.WriteLine(a + b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

        }
        public void Assignment(int a, int b)
        {
            int c = a;
            c += 10; c -= 10; c /= 10;
        }
        public void Relational(int a, int b)
        {
            //==,>=,<=,!=
            if (a ==b)
            {

            }
        }
        public void UnaryOperator(int a)
        {
            //pre-crement //post-increment
       //     ++a; a++;--a;

        }
        
        //ternary operator
        public string ternaryPrac(int age)
        {
            //condition  
           return  age > 18 ? "legal citizen" :  "not a citizen";
        }
    }
}
