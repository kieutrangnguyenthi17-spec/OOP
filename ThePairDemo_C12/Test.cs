using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePairDemo_C12

{
    public enum comparison // enum la kieu du lieu liet ke
    {
        theFirstComeFirst = 1, theSecondComesFirst =2
    }
    public class Test
    {
        static void Main(String[] args)
        {
            // creation two students and two dogs
            // and add them to Pair objects
            Student Jesse = new Student("Jesse");
            Student Stacey = new Student("Stacey");

            Dog Milo = new Dog(65);
            Dog Fred = new Dog(12);

            Pair studentPair = new Pair(Jesse, Stacey);
            Pair dogPair = new Pair(Milo, Fred);

            Console.WriteLine("studentPair\t\t\t: {0}", studentPair.ToString());
            Console.WriteLine("dogPair\t\t\t\t: {0}", dogPair.ToString());
            // instantiate the delegates
            Pair.WhichIsFirst theStudentDelegate = new Pair.WhichIsFirst(Student.WhichStudentComesFirst);
            Pair.WhichIsFirst theDogDelegate = new Pair.WhichIsFirst(Dog.WhichDogComesFirst);
            //sort using the delegate
            studentPair.Sort(theStudentDelegate);
            Console.WriteLine("After Sort studentPair\t\t: {0}", studentPair.ToString());
            studentPair.ReverseSort(theStudentDelegate);
            Console.WriteLine("After ReverseSort studentPair\t: {0}", studentPair.ToString());

            dogPair.Sort(theDogDelegate);
            Console.WriteLine("After Sort dogPair\t\t: {0}", dogPair.ToString());
            dogPair.ReverseSort(theDogDelegate);
            Console.WriteLine("After ReverseSort dogPair\t: {0}", dogPair.ToString());

            Console.ReadKey();

        }
    }
}
