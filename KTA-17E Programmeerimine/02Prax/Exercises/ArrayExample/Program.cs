using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("nahk");
            arrayList.Add(5);
            arrayList.Add(5.77);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            Console.WriteLine($"Mulle maitseb {arrayList[0]}");

            arrayList.Add("Kool");

            Console.WriteLine(arrayList[arrayList.Count -1]);
            Console.ReadLine();
        }
    }
}
