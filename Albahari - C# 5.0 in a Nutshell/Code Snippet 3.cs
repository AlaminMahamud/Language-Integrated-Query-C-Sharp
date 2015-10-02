using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tom", "Dick", "Harry", "Marry", "Jay" };
            IEnumerable<string> filteredNames = names
                                                .Where(n => n.Contains("a"))
                                                .OrderBy(n => n.Length)
                                                .Select(n => n.ToUpper());
            foreach (var n in filteredNames)
            {
                Console.WriteLine(n);
            }
        }
    }
}
