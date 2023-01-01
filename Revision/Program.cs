using System.Runtime.CompilerServices;

namespace Revision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Find The minimum of series of number
            //Console.Write("Enter the size of the array:");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] number = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    number[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine();
            //int min = number[0];
            //for (int i = 0; i < number.Length; i++)
            //{
            //    min = Math.Min(min, number[i]);
            //}
            //Console.WriteLine($"The minimum number in the array is: {min}."); 
            #endregion

            #region Welcome + active Years
            //Console.Write("Enter Name: ");
            //string name = Console.ReadLine();
            //Console.Write("Enter hire Date in form YYYY-MM-DD: ");
            //DateTime hireDate = Convert.ToDateTime(Console.ReadLine());

            //int activeYear = DateTime.Now.Year - hireDate.Year;
            //Console.WriteLine($"Welcome {name}, You are a friend to us for {activeYear} years."); 
            #endregion


            #region Count numbers from 1 to number with and without loop
            //Console.Write("Enter a number: ");
            //double number = Convert.ToDouble(Console.ReadLine());
            //double total = ((number + 1) / 2) * number;
            //Console.WriteLine($"The sum of numbers from 1 to {number} = {total}");

            //Console.Write("Enter a number: ");
            //double number = Convert.ToDouble(Console.ReadLine());
            //double sum = 0;
            //for (double i = 1; i <= number; i++)
            //{
            //    sum += i;

            //}
            //Console.WriteLine(sum);


            #endregion


            #region Swap Two Numbers
            //int x = 10;
            //int y = 5;
            //x = x + y;   // x = 10 + 5 = 15
            //y = x - y;  //  y = 15 - 5 = 10 (swapped)
            //x = x - y; //   x 15 - 10 = 5   (swapped)
            //Console.WriteLine($"X = {x}");
            //Console.WriteLine($"Y = {y}");

            // 2nd way
            // 
            //int temp = x;
            //x = y;
            //y = temp;
            //Console.WriteLine($"X = {x}");
            //Console.WriteLine($"Y = {y}");

            //3rd way

            //Console.Write("Enter first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //SwapNumbers(ref num1, ref num2);

            // 4th way with * and /
            //int x = 10;
            //int y = 5;
            //x = x * y; //  10 * 5 = 50
            //y = x / y; //  50 / 5 = 10 (swapped)
            //x = x / y; //  50 / 10 (swapped) = 5 (swapped) 
            //Console.WriteLine($"X = {x}");
            //Console.WriteLine($"Y = {y}");


            //5th way singel statement

            //   int x = 10; 
            //   int y = 20;


            // //    x + y -     (x = 20) (swapped)  
            ////    10 + 20  -  20 = 30 - 20 = 10 (swapped)
            //   y = x + y   - (x = y);
            //   Console.WriteLine($"X = {x}");
            //   Console.WriteLine($"Y = {y}");





            #endregion

            #region Multiplication table of even numbers <= 12
            //int x = 2;
            //do
            //{
            //    int y = 1;
            //    if (x % 2 == 0)
            //    {
            //        Console.WriteLine($"The Multiplication table of no {x}: ");

            //        do
            //        {

            //            Console.WriteLine($"{x} * {y} = {x * y}");

            //            y++;
            //        } while (y <= 12);
            //        Console.WriteLine();
            //    }
            //    x++;
            //} while (x <= 12); 


            //////////////////////////////////////////////////

            //int x = 0;
            //do
            //{
            //    int y = 1;

            //    Console.WriteLine($"The Multiplication table of no {x}: ");

            //    do
            //    {

            //        Console.WriteLine($"{x} * {y} = {x * y}");

            //        y++;
            //    } while (y <= 12);
            //    Console.WriteLine();

            //    x = x + 2;
            //} while (x <= 12);
            #endregion

            #region Enter number to run task 
            //int input;
            //do
            //{
            //    Console.Write("Enter a number: ");
            //    input = Convert.ToInt32(Console.ReadLine());
            //    switch (input)
            //    {
            //        case 1:
            //            Console.WriteLine("Task 1 Started.");
            //            break;
            //        case 2:
            //            Console.WriteLine("Task 2 Started.");
            //            break;
            //        case 3:
            //            Console.WriteLine("Task 3 Started.");
            //            break;
            //        case 4:
            //            Console.WriteLine("Task 4 Started.");
            //            break;
            //        case 0:
            //            return; // termiate the loop and exit
            //        default:
            //            Console.WriteLine("invalid inpuet");
            //            break;
            //    }

            //} while (input >= 0 &&  input < 5); 
            #endregion

        }




    }
    #region Method to Swap numbers
    //public static void SwapNumbers(ref int num1 , ref int num2)
    //{
    //    num1 = num1 + num2;
    //    num2 = num1 - num2;
    //    num1 = num1 - num2;

    //    Console.WriteLine();
    //    Console.WriteLine($"First Number become: {num1}");
    //    Console.WriteLine($"Second Number become: {num2}");
    //} 
    #endregion

}
