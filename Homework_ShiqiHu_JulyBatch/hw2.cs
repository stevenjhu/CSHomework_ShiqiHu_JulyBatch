using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            

            
            string start = "";
            string maxStart = "";
            int maxsqLength = 1;

            //first iterator
            for (int i = 0; i < arr.Length; i++)
            {
                start = arr[i]; //first letter of the sequence
                int sqLength = 1;

                //second iterator
                for (int j = i+1; j < arr.Length; j++)
                {
                    //if the next letter is the same as the start of the sequence, subsequence number++, and continue searching
                    //else, set first iterator to one before second iterator's index (ready for next iteration), stop inner loop
                    if (arr[j] == start)
                    {
                        sqLength++;
                    }
                    else
                    {
                        i = j-1;
                        break;
                    }
                }

                //if the subsequence has longer sequence than longest sequence so far
                //then record subsequence by casting stringbuilder to string
                //then clear stringbuilder
                if (sqLength > maxsqLength)
                {
                    maxStart = start;
                    maxsqLength = sqLength;
                }
            }

            //output sequence
            Console.Write(maxStart);
            for (int i = 0; i < maxsqLength-1; i++)
            {
                Console.Write(" {0}",maxStart);
            }
            Console.WriteLine();
        }

        //7
        public static void mostFrequentNum(string str)
        {
            string[] arr = str.Split(' ');
            Dictionary<string, int> dict = new Dictionary<string, int>(); 

            foreach (string s in arr)
            {
                if (dict.ContainsKey(s))
                {
                    dict[s]++;
                }
                else
                {
                    dict.Add(s, 1);
                }
            }

            //after all iterations
            List<string> maxStr = new List<string>();
            int max = 0;
            foreach (KeyValuePair<string,int> i in dict)
            {
                if (i.Value > max)
                {
                    max = i.Value;
                    maxStr.Add(i.Key);
                } else if (i.Value == max)
                {
                    maxStr.Add(i.Key);
                }
            }

            if (maxStr.Count ==1)
            {
                Console.WriteLine("The number {0} is the most frequent (occur {1} times)", maxStr[0],max);
            } else
            {
                Console.Write("The number ");
                for (int i = 0; i < maxStr.Count; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(maxStr[i]);
                    }else if (i == maxStr.Count-1)
                    {
                        Console.Write(" and {0}", maxStr[i]);
                    }
                    else
                    {
                        Console.Write(", {0}", maxStr[i]);
                    }
                }
                Console.WriteLine(" have the same maximal frequency (each occurs {0} times). The leftmost of them is {1}.", max, maxStr[0]);

            }
            
        }
        
        //Practice Strings
        //1
        //mode: true for char-array method, false for print-reverse method
        public static void reverseStr(bool mode)
        {
            string input = Console.ReadLine();
            char[] temp = input.ToCharArray();
            Array.Reverse(temp);
            if (mode)
            {
                string output = new string(temp);
                Console.WriteLine(output);
            }
            else
            {
                foreach (char c in temp)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }

        //2 --incomplete
        public static void reverseSentence(string sen)
        {
            //string[] words = sen.Split(new char[] {'.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', ''', '\\', '/','!','?',' '});
            string[] words = Regex.Split(sen, "[.,:;=()&\\/!?\\s\\[\\]\"\']");
            
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

        }

        //3
        public static void palindrome(string sen)
        {
            string[] arr = Regex.Split(sen, "[^a-zA-Z]");
            List<string> list = new List<string>();

            bool isFirst = true;
            for (int i = 0; i <arr.Length ; i++)
            {
                if (arr[i] != "" && IsPalindrome(arr[i]))
                {
                    list.Add(arr[i]);
                }
            }
            list.Sort();
            for (int i = 0; i < list.Count ; i++)
            {
                if (isFirst)
                {
                    Console.Write(list[i]);
                    isFirst = false;
                }
                else
                {
                    Console.Write(", {0}", list[i]);
                }
            }
            Console.WriteLine();
        }
        public static bool IsPalindrome(string s)
        {
            StringBuilder sb = new StringBuilder(100);
            foreach (char item in s)
            {
                if (char.IsLetterOrDigit(item))
                {
                    sb.Append(item);
                }
            }
            string str1 = sb.ToString();
            char[] temp = str1.ToCharArray();
            Array.Reverse(temp);
            string str2 = new string(temp);
            return str1 == str2;
        }

        //4
        public static void urlParser(string url)
        {
            Uri uri;
            string protocol,server,resource;
            if (!url.Contains("://"))
            {
                protocol = "";
                server = url.Substring(0,url.IndexOf('/')==-1 ? url.Length : url.IndexOf('/'));
                resource = url.IndexOf('/') == -1 ? "" : url.Substring(url.IndexOf('/')+1);
            }
            else
            {
                uri = new Uri(url);
                protocol = uri.Scheme;
                server = uri.Host;
                resource = uri.PathAndQuery == "/" ? "":uri.PathAndQuery.Substring(1);
            }
            
            
            //int end_index_server = url.IndexOf("://");
            //int start_index_employee = url.Substring(end_index_server + 3).IndexOf('/')+ (end_index_server + 3) + 1; //index or -1 if not found
            //string protocol = url.Substring(0, end_index_server-0);
            //string server = url.Substring(end_index_server + 3, start_index_employee - end_index_server - 4);
            //string resource = url.Substring(start_index_employee);
            Console.WriteLine(url);
            Console.WriteLine("[protocal] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resource);
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

            //mostFrequentNum("4 1 1 4 2 3 4 4 1 2 4 9 3");
            //mostFrequentNum("7 7 7 0 2 2 2 0 10 10 10");

            //reverseStr(true);
            //reverseStr(false);

            //reverseSentence("C# is not C++, and PHP is not Delphi!");
            //palindrome("Hi,exe? ABBA! Hog fully a string: ExE. Bob");

            //urlParser("https://www.apple.com/iphone");
            //urlParser("ftp://www.example.com/employee");
            //urlParser("https://google.com");
            //urlParser("www.apple.com");
        }
    }
}
