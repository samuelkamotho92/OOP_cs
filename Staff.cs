using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectone
{
    public class Staff
    {
        //fields
       public string name;
       public string unit;
       public  int salary;

        //constructor

        public Staff(string name,string unit,int salary)
        {
            this.name = name;
            this.unit = unit;
            this.salary = salary;
        }

        public void steps(int n)
        {
            for (int i = 1; i <= n; i++)
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


        private int studentScore()
        {
            int[] score = new int[3];
            score[0] = 1;
            score[1] = 2;
            score[2] = 3;
            int total = 0;
            for (int i = 0; i < score.Length; i++)
            {
                total += score[i];
            }
            return total;
        }

        public void pension()
        {
            ArrayList pesa = new ArrayList();
            pesa.Add(20000);
            pesa.Add(40000);
            pesa.Add(50000);
            pesa.Add(60000);
            pesa.Insert(1, 10000);
            foreach(int i in pesa)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"{pesa.Capacity} values");
        }

        public void getLecDetails()
        {
           int finalScore = studentScore();
            pension();
            Console.WriteLine(finalScore);
            Console.WriteLine($" Sir {name} does teach {unit} and gets {salary}");
        }

    }
}
