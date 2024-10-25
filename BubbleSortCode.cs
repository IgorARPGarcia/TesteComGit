using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit.ArchivesCommit
{
    
    public class BubbleSort
    {
        static int i, j, auxNumber, lenght;

        public static void Method(int[] numbers, int lenght)
        {
            lenght = numbers.Length;
            for(i = 0; i < lenght; i++)
            {
                for(j = 0; j < lenght - 1; j++)
                {
                    if(numbers[j] > numbers[j + 1])
                    {
                        auxNumber = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = auxNumber;
                    }
                }
            }
            for(i = 0; i < lenght; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
