using System;
using System.Diagnostics;

namespace campus_intermediate_programming_II
{
    public static class Reverse
    {
        // Retorna un array de forma inversa utilizando Queue
        public static void WithQueue(int[] array)
        {
            var timer = new Stopwatch();

            timer.Start();
            Queue<int> queue = new Queue<int>();

            foreach (var item in array)
            {
                queue.Enqueue(item);
            }

            var arrayReversed = queue.Reverse().ToArray();
            foreach (var item in arrayReversed)
            {
                Console.WriteLine(item);
            }
            timer.Stop();

            TimeSpan executionTime = timer.Elapsed;
            Console.WriteLine($"\nEl tiempo de ejecución de ReverseWithQueue ha sido de {executionTime:m\\:ss\\.fff} milisegundos");
            Console.WriteLine($"Primer elemento del array ya inverso: {arrayReversed[0]}");
        }

        // Retorna un array de forma inversa utilizando List
        public static void WithList(int[] array)
        {
            var timer = new Stopwatch();

            timer.Start();

            List<int> list = new List<int>();
            foreach (var item in array)
            {
                list.Add(item);
            }
            List<int> reversedList = Enumerable.Reverse(list).ToList();
            reversedList.ForEach((item) => Console.WriteLine(item));
            timer.Stop();

            TimeSpan executionTime = timer.Elapsed;
            Console.WriteLine($"\nEl tiempo de ejecución de ReverseWithList ha sido de {executionTime:m\\:ss\\.fff} milisegundos");
            Console.WriteLine($"Primer elemento del array ya inverso: {reversedList[0]}");
        }

        // Retorna un array de forma inversa utilizando Dictionary
        public static void WithDictionary(int[] array)
        {
            var timer = new Stopwatch();

            timer.Start();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                dictionary.Add(i, array[i]);
            }
            var reversedDictionary = dictionary.Reverse();

            var arrayReversed = reversedDictionary.Select(r => r.Value).ToArray();

            foreach (var item in arrayReversed)
            {
                Console.WriteLine(item);
            }
            timer.Stop();

            TimeSpan executionTime = timer.Elapsed;
            Console.WriteLine($"\nEl tiempo de ejecución de ReverseWithDictionary ha sido de {executionTime:m\\:ss\\.fff} milisegundos");
            Console.WriteLine($"Primer elemento del array ya inverso: {arrayReversed[0]}");
        }

    }
}
