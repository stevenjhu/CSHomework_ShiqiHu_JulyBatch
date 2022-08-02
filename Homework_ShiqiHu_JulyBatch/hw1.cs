//1.What type would you choose for the following “numbers”?
//long                  A person’s telephone number(10-digit number, max 999-999-9999, bigger than unsigned int limit)
//ushort                A person’s height(if height is calculated in the metric system, for feet+inch combination, byte[] would be a better choice)
//byte                  A person’s age
//char[]                A person’s gender (Male, Female, Prefer Not To Answer) (Could also just use char to store one-letter abbreviation like 'M','F','P')
//int                   A person’s salary 
//int[]                 A book’s ISBN (5 variable-length numeric combinations)
//short                 A book’s price (unless a book is more expensive than 32767 dollars)
//ushort                A book’s shipping weight 
//uint                  A country’s population (non-negative number, largest population in a country is approx. 1.4b)
//double                The number of stars in the universe(2*10^23 stars in the universe)
//ushort                The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business)

//2.What are the difference between value type and reference type variables? What is boxing and unboxing?
/*                  Value                       |                       Reference
 * Holds      | actual value                            memory address/reference to value
 * Stores in  | stack                                   heap 
 * Collected  |
 * by Garbage | no                                      yes
 * Collector  |
 * Created by | struct, enum                            class, interface, delegate, array
 * Accept null| no                                      yes
 */
//Boxing    : value type -> reference type 
//Unboxing  : reference type -> value type
/*
 * int i = 10;
 * Object o = i;//boxing
 * int j = (int)o;//unboxing
 */

//3. What is meant by the terms managed resource and unmanaged resource in .NET
/*
 * Managed resources are those recognized by the garbage collector, while the unmanaged resources cannot be.
 * Overtime, unmanaged resources can cause memory leak, which would impair the overall performance of the program
 */

//4. Whats the purpose of Garbage Collector in .NET?
//The main purpose of the Garbage Collector is to automatically free up memory. It allocates objects on managed heap efficiently.
//The Garbage Collector divides objects into three categories. Generation 0, 1, and 2, which handle short-lived, buffer in between, and long-lived objects.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_ShiqiHu_JulyBatch
{
    internal class hw1
    {
        //Playing with Console App
        //lucky number generator
        public static void luckyNumGenerator()
        {
            Console.WriteLine("Welcome to Astrology Weekly! Enter the day of the week to see this week's lucky number for each day.");
            string num = Console.ReadLine();
            Random random = new Random();
            Console.WriteLine($"Your lucky number for that day is: {random.Next(1, 20)}");
        }

        //1. Understanding Types
        public static void understandingTypes()
        {
            string[] arr = { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal" };
            int[] size = { sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort), sizeof(int), sizeof(uint), sizeof(long), sizeof(ulong), sizeof(float), sizeof(double), sizeof(decimal) };
            string[] min = { sbyte.MinValue.ToString(), byte.MinValue.ToString(), short.MinValue.ToString(), ushort.MinValue.ToString(), int.MinValue.ToString(), uint.MinValue.ToString(), long.MinValue.ToString(), ulong.MinValue.ToString(), float.MinValue.ToString(), double.MinValue.ToString(), decimal.MinValue.ToString() };
            string[] max = { sbyte.MaxValue.ToString(), byte.MaxValue.ToString(), short.MaxValue.ToString(), ushort.MaxValue.ToString(), int.MaxValue.ToString(), uint.MaxValue.ToString(), long.MaxValue.ToString(), ulong.MaxValue.ToString(), float.MaxValue.ToString(), double.MaxValue.ToString(), decimal.MaxValue.ToString() };

            Console.WriteLine("{0,15} {1,15} {2,35} {3,35}\n", "Data Type", "Memory Usage", "Min Value", "Max Value");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0,15} {1,10} bytes {2,35} {3,35}", arr[i], size[i], min[i], max[i]);
            }
        }

        //2. Century converter
        public static void centuryConverter()
        {
            //multiplier to their next in rank unit of measurement
            //const int century = 100;
            //const int year = 365;
            //const int day = 24;
            //const int hour = 60;
            //const int minute = 60;
            //const int second = 1000;
            //const int millisecond = 1000;
            //const int microsecond = 1000;
            string[] units = { "centuries", "years", "days", "hours", "minutes", "seconds", "milliseconds", "microseconds", "nanoseconds" };
            double[] multiplier = { 1, 100.00, 365.24, 24, 60, 60, 1000, 1000, 1000 };
            Console.WriteLine("Century Converter\nPlease enter a number to convert into different time units: ");
            double input = (double)Int32.Parse(Console.ReadLine());

            Console.WriteLine($"{input} {units[0]}");
            double num = input;
            for (int i = 1; i < units.Length; i++)
            {
                num = num * multiplier[i];
                Console.WriteLine($" = {(ulong)Math.Ceiling(num)} {units[i]}");
            }
        }

        //Controlling Flow and Converting Types
        //1. What happens when you divide an int variable by 0?
        //System.DivideByZeroException  
        //2. What happens when you divide a double variable by 0?
        //Outputs Infinity
        //3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
        //Directly setting a number bigger than the limit of an int variable will not be allowed by the IDE.
        //However, if using Math.Pow to create overflow, the variable is set to the minium value of int data type.
        //int a = (int)Math.Pow(10, 100);
        //Console.WriteLine(a==int.MinValue);
        //4. What is the difference between x = y++; and x = ++y;?
        //The order of execution is different.
        //The first one will assign the value of y as a reference of x first, then add 1 to the value of y
        //The second one will add 1 to the value of y, and then assign the reference
        //5. What is the difference between break, continue, and return when used inside a loop statement?
        //break stops the loop and skip any remaining iterations and jumps to the next line outside of the loop
        //continue skips the current iteration of the loop and executes the next iteration
        //return functions like break, but instead of jumping to the next line outside of the loop, it jumps to the first line outside of the current function
        //6. What are the three parts of a for statement and which of them are required?
        //initializer, condition, and iterator. None of them are required.
        //7. What is the difference between the = and == operators ?
        //The first one is the assignment operator, it assigns a reference to its value
        //The second one is an equality operator, it checks if the operands are equal or not
        //8.Does the following statement compile? for ( ; true; ) ;
        //Yes, it does. It executes an infinite loop.
        //9. What does the underscore _ represent in a switch expression?
        //underscore represents the match-all pattern in this pattern-matching expression
        //10. What interface must an object implement to be enumerated over by using the for...each statement ?
        //Implements the System.Collections.IEnumerable or System.Collections.Generic.IEnumerable<T> interface

        //Practice loops and operators
        //1.1
        public static void fizzBuzz()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 15 == 0)
                {
                    Console.Write(" fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(" fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write(" buzz");
                }
                else
                {
                    Console.Write($" {i}");
                }
            }
        }

        //1.2
        //either set int max's value to be at most 255, or set the initializer in for loop to be of type int
        public static void loop()
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }

        //2
        public static void printPyramid(int level)
        {
            int starPerLevel = 0; //how many stars need to be printed
            int maxPerLevel = level * 2 - 1; //maximum number of stars in a row
            int blankspace = 0;
            for (int i = 0; i < level; i++)
            {
                starPerLevel = i * 2 + 1;
                blankspace = (maxPerLevel - starPerLevel) / 2;
                for (int j = 0; j < blankspace; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < starPerLevel; j++)
                {
                    Console.Write('*');
                }
                for (int j = 0; j < blankspace; j++)
                {
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        //3
        public static void guessNum()
        {
            Console.WriteLine("Guess a number between 1 and 3.");
            int correctNumber = new Random().Next(3) + 1;
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("This number is not between 1 and 3");
            }
            else if (correctNumber == guessedNumber)
            {
                Console.WriteLine("Correct");
            }
            else if (correctNumber > guessedNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (correctNumber < guessedNumber)
            {
                Console.WriteLine("Lower");
            }

        }

        //4
        public static void birthdayConverter(int year, int month, int day)
        {
            TimeSpan interval = DateTime.Now - new DateTime(year, month, day);
            Console.WriteLine("This person has existed on Earth for {0} days", interval.Days);

            int daysToNextAnniversary = 10000 - (interval.Days % 10000);
            DateTime anniversary = DateTime.Now.AddDays(daysToNextAnniversary);
            Console.WriteLine("{0} days until the next anniversary", daysToNextAnniversary);
            Console.WriteLine("The next anniversary will be on {1}/{2}/{0}", anniversary.Year, anniversary.Month, anniversary.Day);
        }

        //5
        public static void greeting()
        {
            DateTime dt = DateTime.Now;

            //beginning timestamp
            DateTime morning = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 5, 0, 0);
            DateTime afternoon = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 0, 0);
            DateTime evening = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);
            DateTime night = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            //morning:      5:00am to 11:59am
            //afternoon:    12:00pm to 5:59pm
            //evening:      6pm to 11:59pm
            //night:        0am to 4:59am

            //whichever positive timespan is the closest to 0 will be the current time period
            Dictionary<string, TimeSpan> map = new Dictionary<string, TimeSpan>();
            map.Add("Morning", dt - morning);
            map.Add("Afternoon", dt - afternoon);
            map.Add("Evening", dt - evening);
            map.Add("Night", dt - night);

            //bool closerTime = false;
            string timeOfDay = "";
            TimeSpan shortest_timeSpan = new TimeSpan(25, 0, 0); //set to maximum timespan over one day so that the first comparison will always be true
            foreach (string key in map.Keys)
            {
                TimeSpan current_timespan = map.GetValueOrDefault(key);
                //given this iteration's timespan is positive
                if (current_timespan > new TimeSpan(0, 0, 0))
                {
                    //if the current timespan is shorter than the shortest timespan,
                    //then overwrite the value of timeOfDay and shortest_timespan
                    if (current_timespan < shortest_timeSpan)
                    {
                        shortest_timeSpan = current_timespan;
                        timeOfDay = key;
                    }
                }
            }
            Console.WriteLine(DateTime.Now);
            Console.WriteLine($"Good {timeOfDay}");


        }

        //6
        public static void count24()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.Write(0);
                for (int j = 0; j + i <= 24; j += i)
                {
                    Console.Write($",{j + i}");
                }
                Console.WriteLine();
            }
        }

        //public static void Main(string[] args)
        //{
        //    //uncomment one method at a time for better viewing experience
        //    luckyNumGenerator();
        //    understandingTypes();
        //    centuryConverter();
        //    fizzBuzz();
        //    loop();
        //    guessNum();
        //    printPyramid(5);
        //    birthdayConverter(2000, 9, 19);
        //    greeting();
        //    count24();
        //}
    }
}