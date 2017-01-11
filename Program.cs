using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static int[] RandomArray(){
            int[] arr = new int[10];
            Random r = new Random();
            for(int i = 0; i < arr.Length; i++){
                // int rInt = r.Next(5, 25);
                arr[i] = r.Next(5, 25);
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            return arr;
        }





        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomArray();
        }
    }
}
