using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePairDemo_C12
{
    public class Student
    {
        public Student(String name)
        {
            this.name= name;
        }
        //students are ordered alphabetically
        public static comparison WhichStudentComesFirst(Object o1, Object o2)
        {
            Student s1 = (Student)o1;
            Student s2 = (Student)o2;
            return (String.Compare(s1.name, s2.name)<0 ?
                    comparison.theFirstComesFirst :
                    comparison.theSecondComesFirst);
        }
        public override string ToString()
        {
            return name;
        }
        private string name;
    }
}
