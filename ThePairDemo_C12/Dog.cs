using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePairDemo_C12
{
    public class Dog
    {
        public Dog(int weight)
        {
            this.weight=weight;
        }
        //dongs are ordered by weight
        public static comparison WhichDogComesFirst(
            Object o1, Object o2)
        {
            Dog d1 = (Dog)o1;
            Dog s2 = (Dog)o2;
            return d1.weight > d2.weight ?
                comparison.theSecondComesFirst :
                comparison.theFirstComesFirst;
        }
        public override string ToString()
        {
            return weight.ToString();
        }
        private int weight;
    }
}
