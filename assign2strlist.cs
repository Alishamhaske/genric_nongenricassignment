using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.genric_nongenricassignment
{
    internal class assign2strlist
    {
        static void Main(string[] args)
        {
            //WAP to create an array of 5 strings to store students name, sort names in ascending order & display using foreach loop.

            List<string> l2 = new List<string>();
            l2.Add("tanuja");
            l2.Add("sandesh");
            l2.Add("payal");
            l2.Add("Alisha");
            l2.Add("riya");
            l2.Add("shubham");
            l2.Add("Pradhnya");
            l2.Sort();  //sort string
            foreach (string item in l2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
