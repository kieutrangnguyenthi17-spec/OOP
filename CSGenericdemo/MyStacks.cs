using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGenericdemo
{
    public class MyStacks<T>   // luu nhieu gia tri
    {
        private List<T> items = new List<T>();

        public void Push(T item) => items.Add(item);
        public T Pop()
        {
            T item = items[items.Count-1]; // phan tu cuoi
            items.RemoveAt(items.Count - 1);
            return item;
        }
    }
}
// box chi luu 1 gia tri