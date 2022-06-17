using System;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the numbers arrayelements");
            //int n = int.Parse(Console.ReadLine());
            int[] a = {1,2,3,4,5 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];

            }

            Console.WriteLine(sum);
        }
    }
    class ArraySum
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter length of array");
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];
            int sum = 0;
            for (int i = 0; i <a.Length; i++)
            {
                Console.WriteLine("Enter values");
                a[i] =int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Sum= "+sum);
              
        }
    }
    class OddPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x]; //{1,2,3,4,5,6,7,8,9};
            for (int i = 0; i <a.Length; i++)
            {
                Console.WriteLine("Enter the values");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <a.Length; i=i+2)
            {

                Console.WriteLine(a[i]);
            }
        }
    }
    class sumOfArrayElement
    {
        static void Main(string[] args)
        {

        }
    }
}
