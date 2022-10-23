// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;

namespace CodeForce
{

    class Program
    {
        static void Main()
        {
            int NumOfTests = int.Parse(Console.ReadLine());
            for (int i = 0; i < NumOfTests; i++)
            {
                string enteredValues = Console.ReadLine();
                string[] anArray = enteredValues.Split();
                int[] intArray = anArray.Select(x => int.Parse(x)).ToArray();

                int x = intArray[0];
                int y = intArray[1];
                long answer = NOD(x, y);
                Console.WriteLine(answer);
            }
        }
        static long NOD (int var1, int var2)
        {
            if (var1 == 0)  return var2;
            else
            {
                while (var2 != 0)
                {
                    if (var1 > var2)
                        var1 -= var2;
                    else
                        var2 -= var1;
                }
                return var1;
            }
        }
    }
}
