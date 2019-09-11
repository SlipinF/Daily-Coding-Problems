using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfnumbers = new int[5] {1,4,3,4,1};

            Console.WriteLine(ListCheck().ToString());
            Console.ReadKey();

            bool ListCheck()
            {
                bool result = false;
                for (int i = 0; i < arrayOfnumbers.Length; i++)
                {
                    if (arrayOfnumbers[i] != arrayOfnumbers[arrayOfnumbers.Length -1 - i])
                    {
                        result = false;
                        return result;
                    }
                    else
                    {
                        result = true;
                    }
                }
                return result;
            }
        }
    }
}
