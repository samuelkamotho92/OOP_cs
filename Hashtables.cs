using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectone
{
    public class Hashtables
    {
        public void Practhashtables()
        {
            Hashtable car = new Hashtable();
            car.Add("name", "BMW");
            car.Add("color", "Black");
            car.Add("owner", "samkam");
            car.Remove("owner");
            car["color"]= "white";
            //Hashtable employee = new Hashtable
            //{
            //    { "EId", 1001 },
            //    { "Name", "James" },
            //    { "Salary", 3500 },
            //    { "Location", "Mumbai" },
            //    { "EmailID", "a@a.com" }
            //};
            //Hashtable courses = new Hashtable
            //{
            //    {"name","javascript" },
            //    {"price",2000},
            //};
            //foreach(var prop in courses.Values)
            //{
            //    Console.WriteLine(prop);
            //}
            foreach (var prop in car.Keys)
            {
                Console.WriteLine($"{prop}:{car[prop]}");
            }

        }
    }
}
