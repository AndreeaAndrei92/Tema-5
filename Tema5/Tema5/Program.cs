using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 7, 1, 8, 1 };
            //Console.WriteLine(sumaNrPare(arr));
            //int valoare = 8;
            //Console.WriteLine(sumaElem(arr, valoare));
            //int numar =5;
            //Console.WriteLine(factorial(numar));
            //Console.WriteLine(duplicate(arr));
            //removeDuplicate();
            //int numarSum = 125;
            //Console.WriteLine(sumaNumere(numarSum));
            //int[] arrMajority = { 1, 2, 3, 4, 5, 2, 2, 2, 2 };
            //Console.WriteLine(majority(arrMajority));
            //string first = "test";
            //string second = "tse1t";
            //Console.WriteLine(anagram(first, second));
            //Console.WriteLine(fibonaci(numar));
            //Console.WriteLine(numberBits(numar));
            //string s = "heeelllllooo";
            //Console.WriteLine(removeDuplicateString(s));
            //Console.WriteLine(armstrong(numar));
            //Console.WriteLine(checkPrime(numar));
            //Console.WriteLine(palindromeNumber(numar));
            //reverseLinkedL();
            //selectionSort(arr);
            bubbleSort(arr);


            Console.ReadKey();
        }

        //1-Given an array of ints, write a C# method to total all the values that are even number
        public static int sumaNrPare(int[] arr)
        {
            int suma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    suma += arr[i];
                }
            }
            return suma;
        }

        //2-How to find all pairs of elements in an integer array, whose sum is equal to a given number?
        public static bool sumaElem(int[] arr, int valoare)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j >= 0; --j)
                {
                    if (valoare == arr[i] + arr[j])
                    {
                        Console.WriteLine("Am gasit perechea " + arr[i] + " " + arr[j] + " care impreuna au suma " + valoare);

                    }
                }

            }
            return true;
        }

        //3-How to calculate factorial using recursion in C# + iterative + time difference
        public static int factorial(int numar)
        {
            if (numar == 1)
            {
                return 1;
            }
            else
            {
                return numar * factorial(numar - 1);
            }
        }

        //4-Algorithm to find if Array contains duplicates?
        public static bool duplicate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("Am gasit duplicatul " + arr[j]);
                    }
                    else
                    {
                        Console.WriteLine("Sirul nu contine duplicate");
                    }
                }
            }
            return true;
        }

        //5-How to remove duplicates from a sorted linked list?
        public static void removeDuplicate()
        {
            LinkedList<int> lista = new LinkedList<int>();
            LinkedListNode<int> firstNode = new LinkedListNode<int>(10);
            lista.AddFirst(firstNode);
            LinkedListNode<int> secondNode = new LinkedListNode<int>(20);
            lista.AddAfter(firstNode, secondNode);
            LinkedListNode<int> thirdNode = new LinkedListNode<int>(20);
            lista.AddAfter(secondNode, thirdNode);
            LinkedListNode<int> forthNode = new LinkedListNode<int>(30);
            lista.AddAfter(thirdNode, forthNode);
            LinkedListNode<int> currentNode = firstNode;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                LinkedListNode<int> nextNode = currentNode.Next;
                if (nextNode == null)
                {
                    break;
                }
                if (currentNode.Value == nextNode.Value)
                {
                    nextNode = nextNode.Next;
                }
                currentNode = nextNode;

            }
        }

        //6-How to find sum of digits of a number using Recursion? 
        public static int sumaNumere(int numarSum)
        {
            if (numarSum == 0)
            {
                return 0;
            }
            int result = numarSum % 10 + sumaNumere(numarSum / 10);
            return result;
        }

        //7-Given an unsorted array which has a number in the majority (a number appears more than 50% in the array), find that number?
        public static int majority(int[] arrMajority)
        {
            int majority = 0;
            int number = 0;
            int count = 0;
            for (int i = 0; i <= arrMajority.Length; i++)
            {
                for (int j = i; j < arrMajority.Length; j++)
                {
                    if (arrMajority[i] == arrMajority[j])
                    {
                        count++;
                    }
                }
                if (count >= arrMajority.Length / 2)
                {
                    majority = count;
                    number = arrMajority[i];
                    count = 0;
                }
                count = 0;
            }
            return number;
        }

        //8-Detect a cycle in a singly linked list
        public static bool isCircular()
        {
            LinkedList<int> lista = new LinkedList<int>();
            LinkedListNode<int> firstNode = new LinkedListNode<int>(10);
            lista.AddFirst(firstNode);
            LinkedListNode<int> secondNode = new LinkedListNode<int>(20);
            lista.AddAfter(firstNode, secondNode);
            LinkedListNode<int> thirdNode = new LinkedListNode<int>(30);
            lista.AddAfter(secondNode, thirdNode);
            LinkedListNode<int> fourthNode = new LinkedListNode<int>(40);
            lista.AddAfter(thirdNode, fourthNode);
            if (firstNode != null && firstNode.Next != null)
            {
                var slow = firstNode;
                var fast = firstNode.Next;
                while (slow.Next != null && fast.Next != null && fast.Next.Next != null)
                {
                    if (slow == fast)
                    {
                        return true;
                    }
                    slow = slow.Next;
                    fast = fast.Next.Next;
                }
                return false;
            }
            else
            {
                return firstNode != null ? (firstNode == firstNode.Next) : false;
            }
        }

        //10-Checks if two Strings are Anagram
        public static bool anagram(string first, string second)
        {
            string a = String.Concat(first.OrderBy(c => c));
            string b = String.Concat(second.OrderBy(c => c));

            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //11-Fibonaci
        public static int fibonaci(int numar)
        {
            if (numar == 0 || numar == 1)
            {
                return numar;
            }
            else
            {
                return fibonaci(numar - 1) + fibonaci(numar - 2);
            }
        }

        //12-Count total number of set bits in a 32-bit Integer
        public static int numberBits(int numar)
        {
            numar = numar - ((numar >> 1) & 0x55555555);
            numar = (numar & 0x33333333) + ((numar >> 2) & 0x33333333);
            return (((numar + (numar >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
        }

        //13-Remove duplicate characters from String
        public static string removeDuplicateString(string s)
        {
            string newString = null;
            List<char> list = new List<char>();
            foreach (var elem in s)
            {
                if (list.Contains(elem))
                {
                    continue;
                }
                newString += elem.ToString();
                list.Add(elem);
            }
            return newString;
        }

        //15-number is Armstrong number or not
        public static bool armstrong(int numar)
        {
            int remainder = 0;
            int sum = 0;
            for (int i = numar; i > numar; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;
            }
            if (numar == sum)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //16-check if a number is Prime or not
        public static bool checkPrime(int numar)
        {
            int count = 0;
            for (int i = 1; i <= numar; i++)
            {
                if (numar % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //17-check if a number is a Palindrome
        public static bool palindromeNumber(int number)
        {
            int sum = 0;
            int i = 0;
            for (i = number; number != 0; number = number / 10)
            {
                sum = sum * 10 + number % 10;
            }
            if (i == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //18-reverse a linked list
        public static void reverseLinkedL()
        {
            LinkedList<int> lista = new LinkedList<int>();
            LinkedListNode<int> firstNode = new LinkedListNode<int>(10);
            lista.AddFirst(firstNode);
            LinkedListNode<int> secondNode = new LinkedListNode<int>(20);
            lista.AddAfter(firstNode, secondNode);
            LinkedListNode<int> thirdNode = new LinkedListNode<int>(30);
            lista.AddAfter(secondNode, thirdNode);
            LinkedList<int> copyList = new LinkedList<int>();
            LinkedListNode<int> start = copyList.Last;
            while (start != null)
            {
                copyList.AddFirst(start.Value);
                start = start.Previous;
            }

            lista = copyList;
            foreach (var elem in lista)
            {
                Console.WriteLine(elem);
            }

        }

        //19-rotate an array by a given pivot
        public static void rotateArray(int[] arr)
        {
            var temp = arr[0];
            for (var i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = temp;
            foreach (var elem in arr)
            {
                Console.WriteLine(elem);
            }
        }

        //20-Sorting an Array using Selection Sort
        public static void selectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }
            Console.Write("Sorted array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        //21-Sorting an Array using Bubble Sort
        public static void bubbleSort(int[] arr)
        {
            int temp;
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array:");
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }
        }
    }
}
