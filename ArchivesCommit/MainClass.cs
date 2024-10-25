using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit.ArchivesCommit
{
    public class MainClass : BubbleSort
    {
        static int lenght, i, numbers;
        static int[] numbersArray;
        public MainClass() 
        {
            Console.Write("how many number do you want to type?: ");
            lenght = int.Parse(Console.ReadLine());

            numbersArray = new int[lenght];

            for(i = 0; i < lenght; i++) 
            {
                Console.Write($"Type any number {i + 1}: ");
                numbers = int.Parse(Console.ReadLine());
                numbersArray[i] = numbers;
            }

            Method(numbersArray, lenght);
        }

        static void Main(string[] args) 
        {
            new MainClass();
        }

    }
}
