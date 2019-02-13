using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
using System.IO;
namespace facorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 num, nextNum, F=1;
            Write("Input Number (less than 15) -->");
            newInput: num = Int64.Parse(ReadLine());
            nextNum = num;
            F = num;
            if (num > 15)
            {
                WriteLine("Sorry number must be less than 15. Tray Again");
                Write("Input Again-->");
                goto newInput;
            }
            else {
                factorialStart:
                F =F * (nextNum - 1);
                nextNum = nextNum - 1;
                if (nextNum != 1) goto factorialStart;
                else WriteLine("The Factorial of "+num+" is equal to "+F);
            }
            
        }
    }
}
