using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.genric_nongenricassignment
{
    internal class stringfrequecy
    {
        //find the frequency of each elements
        static void Main(string[] args)
        {

            List<string> list = new List<string>()
            { "Pune", "Pune", "Mumbai", "Nashiq", "Mumbai", "Pune", "satara", "satara" };
            // DuplicateRemove(list);
            foreach (string i in list)
            {
                Console.WriteLine(i); 
            }
            ListFrequency(list);
        }

        ///   
        public static void ListFrequency(List<string> list)
        {

            Dictionary<string, int> d1 = new Dictionary<string, int>();

            for (int i = 0; i < list.Count; i++)
            {
                int cnt = 1;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        cnt++;
                        list.RemoveAt(j);
                    }
                }
                // int cnt = list[i].Count();
                d1.Add(list[i], cnt);

            }
            foreach (KeyValuePair<string, int> item in d1)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

        }
    }
}
