using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGenericDemo03
{
    public class Demorepo
    {
        static void Main(string[] args)
        {
            IRepository<string> repo = new MemoryRepository<string>();
            repo.Add("Alice");
            repo.Add("Bob");

            foreach (var name in repo.GetAll())
                Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
