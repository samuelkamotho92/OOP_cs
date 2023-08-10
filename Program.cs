// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Projectone;
namespace Program;
class Program { 
    static void Main(string[] args)
    {
        Student class1 = new Student("samkam", 30);
        Result student2 = new Result("literature", 66);
        Staff lectTwo = new Staff("Ireri", "Digital logic", 10000);
        Stepscal stars = new Stepscal();
        Generics valueOne = new Generics();
        Operators operas = new Operators();

        //Steps stepOne = new Steps(int n);
        class1.DisplayStudent();
        //class2.DisplayStudent();
        student2.displayResult();
         lectTwo.getLecDetails();
        lectTwo.steps(3);
        stars.StepsStar(5);
        //bool compareOne = valueOne.AreEqual<int>(10, 10);
        //if (compareOne)
        //{
        //    Console.WriteLine("is equal");
        //}
        //else
        //{
        //    Console.WriteLine("not equal");
        //
        Hashtables Carone = new Hashtables();
        Carone.Practhashtables();
        Dictionary topFour = new Dictionary();
        topFour.eplTeams();
        operas.Arithmetic(5, 2);
    } 
}

