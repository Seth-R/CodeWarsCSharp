using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCSharp._7kyu
{
    internal class ListFiltering
    {
        public void GetIntegersFromList(List<object> listOfItems)
        {
            var list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
            var a = list.Where(x => x.GetType() == typeof(int)).Cast<int>();

            Console.WriteLine(a);
        }
    }
}
