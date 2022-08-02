using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_ShiqiHu_JulyBatch
{
    internal class hw2
    {
        //1. When to use String vs.StringBuilder in C# ?
        //string is immutable, but stringbuilder is.
        //So when someone needs to change part of a string, use stringbuilder and can later cast to string if necessary
        //string operation uses more memory than stringbuilder
        //2. What is the base class for all arrays in C#?
        //The Array class
        //3. How do you sort an array in C#?
        //using Sort(Array) method of the Array class
        //4. What property of an array object can be used to get the total number of elements in an array?
        //Array.Length
        //5. Can you store multiple data types in System.Array?
        //You can use an object array to store references to values of multiple data types
        //You cannot store values of multiple data types in an array
        //6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
        //a. CopyTo() requires a pre-exising destination array to copy to, Clone() does not
        //b. CopyTo() can copy array starting from certain index, Clone() does not have this option

        //1
        public static void copyArr()
        {
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] arr2 = new int[arr.Length];

            Console.Write('{');
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
                if (i == 0)
                {
                    Console.Write($"{arr2[i]}");
                }
                else
                {
                    Console.Write($", {arr2[i]}");
                }
                
            }
            Console.Write('}');
        }

        //2
        public static void toDoList()
        {
            List<string> todo = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string input = Console.ReadLine();
                string op = input.Substring(0, 2);
                string item = input.Substring(2);

                switch (op)
                {
                    case "+ ":
                        todo.Add(item);
                        printToDoList(todo);
                        break;
                    case "- ":
                        todo.Remove(item);
                        printToDoList(todo);
                        break;
                    case "--":
                        todo.Clear();
                        printToDoList(todo);
                        break;
                    default:
                        Console.WriteLine("User input in incorrect format.");
                        printToDoList(todo);
                        break;
                }
            }
        }
        public static void printToDoList(List<string> list)
        {
            Console.WriteLine("To-Do List: ");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
        }

        //3
        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> list = new List<int>();

            bool isPrime = true;
            for(int i  = startNum; i <= endNum; i++)
            {
                if(i != 0 && i != 1)
                {
                    for (int j = 2; j <= i / 2; j++)
                    {
                        //if dividable, then not prime
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        list.Add(i);
                    }
                    else
                    {
                        isPrime = true;
                    }
                    
                }
            }
            return list.ToArray();
        }

        //4
        public static void rotateSum()
        {
            Console.WriteLine("Enter an array of number on the first line, then enter the number of rotations on another line.");
            string[] arr = Console.ReadLine().Split(' ');
            int repetition = Int32.Parse(Console.ReadLine());

            //initialize a queue, FIFO structure perfect for rotation
            Queue<int> q = new Queue<int>();
            for(int i = arr.Length-1; i >= 0; i--)
            {
                q.Enqueue(Int32.Parse(arr[i]));
            }

            //keep original order
            int[] resultArr =new int[q.Count];
            Array.Reverse(resultArr);
            int[] rotated = new int[resultArr.Length];
            //rotate
            for (int i = 0; i < repetition; i++)
            {
                int temp = q.Dequeue();
                q.Enqueue(temp);

                rotated = q.ToArray();
                Array.Reverse (rotated);
                for (int j = 0; j < rotated.Length; j++)
                {
                    resultArr[j] += rotated[j];
                }
            }

            foreach(int i in resultArr)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
        }

        //5
        public static void longestSequence(string sequence)
        {
            string[] arr = sequence.Split(' ');


            //first iterator
            string start = "";
            string compelete_sq = "";
            int sqLength = 0;
            int maxsqLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                StringBuilder sb = new StringBuilder(start); // initialize stringbuilder for first letter to the entire sequence
                start = arr[i]; //first letter of the sequence
                sqLength = 1;
                maxsqLength = sqLength;
                //second iterator
                for (int j = i+1; j < arr[i].Length; j++)
                {
                    //if the next letter is the same as the start of the sequence, append number to stringbuilder, and continue searching
                    //else, change 'start' value, reset stringbuilder with 'start', stop loop
                    if (arr[j] == start)
                    {
                        sb.Append(" "+start);
                        sqLength++;
                    }
                    else
                    {
                        i = j;
                        break;
                    }
                }
                if (sqLength > maxsqLength)
                {
                    sb.Clear();
                    sb.Append(start);
                }
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            //copyArr();
            //toDoList();
            //foreach (int i in FindPrimesInRange(1, 155))
            //{
            //    Console.WriteLine("{0} ",i);
            //}
            //rotateSum();
            longestSequence("2 1 1 2 3 3 2 2 2 1");
            longestSequence("1 1 1 2 3 1 3 3");
            longestSequence("4 4 4 4");
            longestSequence("0 1 1 5 2 2 6 3 3");
        }
    }
}
