using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, arrCount;
            Console.WriteLine("Enter Length of Array: ");
            arrCount = int.Parse(Console.ReadLine());
            string[] arr = new string[arrCount];

            //taking user i/p
            Console.WriteLine("Enter Data in Array: ");
            for(i=0; i<= arrCount-1; i++)
            {
                Console.WriteLine("String {0} : ", i);
                arr[i] = Console.ReadLine();
            }

            //Calling SortLexicalOrder to sort Strings in Lexical Order
            SortLexicalOrder(arr);

            //Calling SortString for sorting string length wise
            SortStringLength(arr, arrCount);

            Console.WriteLine("Printing Sorted Array-");
            PrintArray(arr, arrCount);

            //sorting string in lexical order
            void SortLexicalOrder(string[] str)
            {
                //Array.Sort(str);
                for (i = 0; i < arrCount; i++)
                {
                    for (int j = 0; j < arrCount - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                        {
                            string temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }

            //sorting string length wise
            void SortStringLength(string []s, int n)
            {
                for (i = 1; i < n; i++)
                {
                    string tempString = s[i];

                    int j = i - 1;
                    try { 
                    while(j>=0 && tempString.Length < s[j].Length)
                    {
                        s[j + 1] = s[j];
                        j--;
                            
                    }
                    s[j+1] = tempString;

                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Error: " + e);
                    }
                }
            }

            //display sorted array data
            void PrintArray(String[] str, int n)
            {
                for (i = 0; i <= n - 1; i++)
                {
                    Console.WriteLine(arr[i]);
                }
               
            }
            Console.ReadLine();
        }
    }
}
