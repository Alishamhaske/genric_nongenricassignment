using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.genric_nongenricassignment
{
    internal class assig1list
    {
        static void Main(string[] args)
        {
            //WAP to create an list of 5 integers. Initialize 5 values. Display using foreach loop.

            List<int> l1 = new List<int>();
            l1.Add(67);
            l1.Add(57);
            l1.Add(77);
            l1.Add(68);
            l1.Add(69);
            l1.Add(27);
            l1.Add(77);
            l1.Remove(68);
            //l1.Clear();
            foreach (int item in l1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
