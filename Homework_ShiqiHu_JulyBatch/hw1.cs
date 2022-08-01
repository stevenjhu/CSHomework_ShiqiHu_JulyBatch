using System;


//1.What type would you choose for the following “numbers”?
//*the ones that are not normally involved in mathematic calculations can be assigned to string
//long or string        A person’s telephone number(10-digit number, max 999-999-9999, bigger than unsigned int limit)
//ushort                A person’s height(if height is calculated in the metric system, for feet+inch combination, byte[] would be a better choice)
//byte                  A person’s age
//char[] or string      A person’s gender (Male, Female, Prefer Not To Answer) (Could also just use char to store one-letter abbreviation like 'M','F','P')
//int                   A person’s salary 
//int[] or string       A book’s ISBN (5 variable-length numeric combinations)
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


//4. Whats the purpose of Garbage Collector in .NET?


//Playing with Console App
//Modify your console application to display a different message. Go ahead and
//intentionally add some mistakes to your program, so you can see what kinds of error
//messages you get from the compiler. The more familiar you are with these messages, and
//what causes them, the better you'll be at diagnosing problems in your programs that you /
//didn't/ intend to add!
//Using just the ReadLine and WriteLine methods and your current knowledge of variables,
//you can have the user pass in quite a few bits of information. Using this approach, create a
//console application that asks the user a few questions and then generates some custom
//output for them. For instance, your program could generate their "hacker name" by asking
//them their favorite color, their astrology sign, and their street address number. The result
//might be something like "Your hacker name is RedGemini480."



public class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine("hello world");
        double star = 2 * Math.Pow(10,23);
        Console.WriteLine(star);
        
    }
}
