using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectone
{
    public class Student
    {

        //fields
        public string Name;
        public int age;


        //constructor
        public Student(string Name,int age)
        {
            this.Name = Name;
            this.age = age;
        }

        //method
      public void DisplayStudent()
        {
            Console.WriteLine($"Am {Name} and {age} years old");
        }
    }

    public class Result {

        //input fields
        public string subjone;
        public int score;
    
        //consructor
        public Result(string subjone,int score)
        {
            this.subjone = subjone;
            this.score = score;
        }

        //access modifier
        private void resultMth()
        {
            Console.WriteLine("This is your end sem score");
        } 

        //method displaying the values
        public void displayResult()
        {
            resultMth();
            Console.WriteLine($"Your score on {subjone} is {score}");
        }
      
    }


}
