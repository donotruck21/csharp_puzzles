using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        //Random Array Challenege
        public static int[] RandomArray(){
            int[] arr = new int[10];
            Random r = new Random();
            for(int i = 0; i < arr.Length; i++){
                arr[i] = r.Next(5, 25);
            }
            int minVal = arr.Min();
            int maxVal = arr.Max();
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine(minVal);
            Console.WriteLine(maxVal);
            return arr;
        }


        //Coin Flip Challenge
        public static string coinFlip(){
            string result = "";
            // Console.WriteLine("Tossing a coin!");

            Random r = new Random();
            int flip = r.Next(2);

            if(flip == 0){
                Console.WriteLine("Heads");
                result = "Heads";
            } else {
                Console.WriteLine("Tails");
                result = "Tails";
            }
            return result;
        }


        public static double TossMultipleCoins(int num){
            int heads = 0;
            int tails = 0;
            Random r = new Random();
            for( int i = 0; i < 5; i++){
                int flip = r.Next(2);
                if(flip == 0){
                    heads++;
                } else {
                    tails++;
                }
            }
            Console.WriteLine(heads+":"+tails);
            return (2.2);
        }

        public static List<string> Names(){
            string[] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            List<string> names2 = new List<string>();
            for(int i = 0; i < names.Length; i++){
                if(names[i].Length > 5){
                    names2.Add(names[i]);
                }
            }
            return names2;
        }






        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // RandomArray();
            // coinFlip();
            // TossMultipleCoins(5);
            // Names();
        }
    }
}
