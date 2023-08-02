using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class program3
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter marks of student " +(i+1) );
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach(int c in marks)
            {
                Console.WriteLine(c);
            }
        }
    }
}
