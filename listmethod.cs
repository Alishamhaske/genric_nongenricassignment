using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.genric_nongenricassignment
{
    internal class listmethod
    {
        static void Main(string[] args)
        {
            //create a list remove duplicate from list

            List<int> l1 = new List<int>();
            int l2 = 0;
            /* l1.Add(11);
             l1.Add(1);
             l1.Add(13);
             l1.Add(14);
             l1.Add(15);
             l1.Add(16);
             l1.Add(17);
             l1.Add(18);
             l1.Add(18);*/
            Console.WriteLine("enter a element");
            for (int i=0;i<=5;i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                l1.Add(x);
            }
           
            Console.WriteLine(  "after list ");
            for(int i=0;i<l1.Count;i++)
            {
              
                 for(int j=i+1;j<l1.Count;j++)
                {
                    if (l1[i] == l1[j])
                    {

                        l1.RemoveAt(j);
                        j--;
              
                    }
          
                }
               
              
            }
            foreach (int i in l1)
            {
                Console.WriteLine(i);
            }

        }
    }
}
