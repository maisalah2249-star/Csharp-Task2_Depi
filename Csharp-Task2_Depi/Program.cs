using System;
using System.Runtime.CompilerServices;
namespace Task2_Depi
{
    class Program
    {
        class person
        {
            public String name;
        }
        static void Main(string[] args)
        {

            /* //Q1
             Console.WriteLine("please enter a number : ");
             int number = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"you have entered : {number}");

             //Q2
             Console.WriteLine("please enter another number : ");
             string x = Console.ReadLine();
             try
             {
                 int num = Convert.ToInt32(x);
                 Console.WriteLine(x);            
             }
             catch ()
             {

                 Console.WriteLine("a format exception has occurred the input you have enterd contains a non numeric characters");

             }

             //Q3
             Console.WriteLine("enter a value for first number : ");
             double n1 = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("enter a value for second number : ");
             double n2 = Convert.ToDouble(Console.ReadLine());


             Console.WriteLine($"Addition is : {n1 + n2}");
             Console.WriteLine($"Subtraction is : {n1 - n2}");
             Console.WriteLine($"Multiplication is : {n1 * n2}");
             if(n2 !=0)
             {
                 Console.WriteLine($"Division is : {n1 / n2}");
             }
             else
             {
                 Console.WriteLine("Division Error : can't divide by zero");
             }
            

            //Q4
            string greeting = "Mai Congratulations";
            string result = greeting.Substring(4, 15);
            Console.WriteLine(result);
            

            //Q5
            int x = 10;
            int y = x;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}"); 
            y = 20;
            Console.WriteLine($"after changing the value of y : y = {y}");

            //Q6
            person p1 = new();
            p1.name = "Mai";
            person p2 = p1;
            Console.WriteLine($"p1 name : {p1.name}");
            Console.WriteLine($"p2 name : {p2.name}");
            

            //Q7
            string fname = "Mai";
            string lname = "Salah";
            string fullname = fname + " " + lname;
            Console.WriteLine($"Full name is : {fname} {lname}");
            */

            /*
             Q8
            a value 1 will be assigned to d
            !(false) = true
             */


            /*
             Q9
             Console.WriteLine(13 / 2 + " " + 13 % 2);
             the answer is 6 1
             */


            int num = 1, z = 5;


            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            /*
             Q10

             */


        }
    }
}