using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ThePairDemo_C12
{
    //a simple collection to hold 2 items
    public class Pair
    {
        //private array to hold the two objects
        private object[] thePair = new object[2];
        //the delegent declaration
        public delegate comparison WhichIsFirst(object obj1, object obj2);
        //passed in constructor take two objects,
        //added in order received
        public Pair(object firstObject, object secondObject)
        {
            thePair[0]=firstObject;
            thePair[1]=secondObject;
        }
        //public method which orders the two objects
        //by whatever criteria the object likes
        public void Sort(WhichIsFirst theDelegatedFunc)
        {
            if (theDelegatedFunc(thePair[0], thePair[1])==comparison.theSecondComesFisrt)
            {
                object temp = thePair[0];
                thePair[0]=thePair[1];
                thePair[1]=temp;
            }
        }
            //public method which orders the two objects
            //by the reverse of whatever criteria the object likes!
            public void ReverseSort(WhichIsFirst theDelegatedFunc)
            {
                if (theDelegatedFunc(thePair[0], thePair[1])==comparison.theFirstComesFirst)
                {
                    object temp = thePair[0];
                    thePair[0]=thePair[1];
                    thePair[1]=temp;
                }
            }
            //ask the two objects to give their string value
            public override string ToString()
        {
            return thePair[0].ToString() + "," + thePair[1].ToString();
        }
    }

}
//giải thích: Pair chứa các đối tượng truyền vào, chưa biết thuộc class student hay dog. Delegate sẽ trỏ vào hàm student hoặc dog
//delegate đóng vai trò như 1 con trỏ