using System;

namespace MinSwaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(minimumSwaps(new int[]{7, 1, 3, 2, 4, 5, 6}));
            Console.WriteLine(minimumSwaps(new int[]{2, 3, 4, 1, 5}));
            Console.WriteLine(minimumSwaps(new int[]{1, 3, 5, 2, 4, 6, 7}));
        }
        
        static int minimumSwaps(int[] arr) {
            int _minSwaps=0;
            for (int i=0; i< arr.Length; i++){
                Console.WriteLine($"Element {i}:");
                    while (arr[i]!= i+1) {
                        int x = arr[i] - 1;
                        int temp = arr[x];
                        Console.WriteLine($"Swapping: {arr[i]} for  {arr[x]}  ");
                        for(int m=0; m<arr.Length ; m++){
                            Console.Write($"{arr[m]} ");
                        }
                        Console.WriteLine();
                        arr[x] = arr[i];
                        arr[i] = temp;
                        for(int m=0; m<arr.Length ; m++){
                            Console.Write($"{arr[m]} ");
                        }
                        _minSwaps += 1;
                        Console.WriteLine("\n--------------");
                    }
            }
            return _minSwaps;
        }
    }
}
