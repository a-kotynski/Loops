using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myInt = 2;

            var userInput1 = Console.ReadLine();
            //Console.WriteLine(userInput1);

            while (myInt < 11)
            {
                myInt += 1;
            }
            Console.WriteLine(myInt);
            for (int i = 0; i < 11; i++)
            {

            }

        }
    }
}



// pętla while wykonywana jest do momentu wykonania warunku
// debugger (czerwona kropka) press F10 for next line
// 'i++' to jest to samo co 'i += 1'

// 'for' loop structure:          for (variable i set at 0; length of said loop; set increment)