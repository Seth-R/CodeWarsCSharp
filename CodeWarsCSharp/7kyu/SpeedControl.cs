using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCSharp._7kyu
{
    internal class SpeedControl
    {
        public void SpeedControlFunction(List<object> listOfItems)
        {
            var x = new double[] { 0.0, 0.01, 0.36, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0, 2.25, 2.5, 2.75, 3.0, 3.25, 3.5, 3.75, 4.0, 4.25, 4.5, 4.75 };
            List<double> a = new List<double>();
            for (int i = 0; i < x.Length; i++)
            {
                var delta_distance = x[i];
                if (i > 1)
                {
                    delta_distance = x[i] - x[i - 1];
                }

                a.Add((3600 * delta_distance) / 15);
            }
            var b = a.Max();

            Console.WriteLine(b);
        }
    }
}
