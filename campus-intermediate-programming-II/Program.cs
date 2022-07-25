using System;
using System.Diagnostics;

namespace campus_intermediate_programming_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Lista de Tuplas
            List<(int, int)> intTuples = new()
            {
                (1, 2),
                (2, 3),
                (3, 4),
                (4, 5),
                (5, 6)
            };

            List<(string Name, string Kind, int Replica, bool Run)> valuesTuples = new()
            {
                ("Aram", "Estudiante", 1, true),
                ("Juan", "Profesor", 4, true),
                ("Lucy", "Estudiante", 2, false),
                ("Arely", "Ilustradora", 5, true),
                ("Fer", "Trabajadora", 7, true)
            };

            Console.WriteLine($"Lista de la tupla de enteros:\n");
            intTuples.ForEach(tuple => Console.WriteLine(tuple));
            
            Console.WriteLine($"\nLista de la tupla de múltiples valores y tipos:\n");
            valuesTuples.ForEach(tuple => Console.WriteLine(tuple));

            // 2. Tipos por valor y por referencia
            var timerClass = new Stopwatch();
            var timerStruct = new Stopwatch();
            var k = 1000000;

            Class[] classes = new Class[k];
            timerClass.Start();
            for (int i = 0; i < classes.Length; i++)
            {
                classes[i] = new Class(i, "nombre", "pass");
            }
            timerClass.Stop();

            TimeSpan executionTimeClass = timerClass.Elapsed;
            Console.WriteLine($"\nEl tiempo de ejecución de Class ha sido de {executionTimeClass:m\\:ss\\.fff} milisegundos\n");

            Struct[] structs = new Struct[k];
            timerStruct.Start();
            for (int i = 0; i < structs.Length; i++)
            {
                structs[i] = new Struct(i, "nombre", "pass");
            }
            timerStruct.Stop();

            TimeSpan executionTimeStruct = timerStruct.Elapsed;
            Console.WriteLine($"El tiempo de ejecución de Struct ha sido de {executionTimeStruct:m\\:ss\\.fff} milisegundos\n");

            // 3. Colas, listas y diccionarios
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nArreglo original:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nArreglo inverso utilizando Queue: ");
            Reverse.WithQueue(array);
            
            Console.WriteLine("\nArreglo inverso utilizando List: ");
            Reverse.WithList(array);

            Console.WriteLine("\nArreglo inverso utilizando Dictionary: ");
            Reverse.WithDictionary(array);

            // 4. Pilas / Palindrome
            string phrase = "Anita lava la tina";
            Console.Write($"\nLa frase: '{phrase}' es palindrome? {Palindrome.IsPalindrome(phrase)}\n");
            string phrase2 = "Ana";
            Console.Write($"\nLa frase: '{phrase2}' es palindrome? {Palindrome.IsPalindrome(phrase2)}\n");
            string phrase3 = "Madam Im Adam";
            Console.Write($"\nLa frase: '{phrase3}' es palindrome? {Palindrome.IsPalindrome(phrase3)}\n");

            string phrase4 = "Fuu";
            Console.Write($"\nLa frase: '{phrase4}' es palindrome? {Palindrome.IsPalindrome(phrase4)}\n");

            Console.ReadKey();
        }
    }
}