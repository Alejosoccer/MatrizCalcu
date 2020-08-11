using System;

namespace MatrizAlejo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] matrizA = new int[2, 3];
            //matrizA[0, 0] = 1;
            //matrizA[0, 1] = 2;
            //matrizA[0, 2] = 4;
            //matrizA[1, 0] = 2;
            //matrizA[1, 1] = 5;
            //matrizA[1, 2] = 8;

            //int[,] matrizB = new int[3, 5];
            //matrizB[0, 0] = 4;
            //matrizB[0, 1] = 9;
            //matrizB[0, 2] = 2;
            //matrizB[0, 3] = 7;
            //matrizB[0, 4] = 3;

            //matrizB[1, 0] = 1;
            //matrizB[1, 1] = 3;
            //matrizB[1, 2] = 3;
            //matrizB[1, 3] = 4;
            //matrizB[1, 4] = 7;

            //matrizB[2, 0] = 6;
            //matrizB[2, 1] = 5;
            //matrizB[2, 2] = 4;
            //matrizB[2, 3] = 1;
            //matrizB[2, 4] = 9;

            Calculadora calculadora = new Calculadora();
            int[,] matrizA = calculadora.CrearMatriz(20, 30);
            int[,] matrizB = calculadora.CrearMatriz(30, 40);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[,] matrizAxB = calculadora.Multiplicar(matrizA, matrizB);
            watch.Stop();
            var miliSegundoTranscurridos = watch.ElapsedTicks;
            Console.WriteLine($"Tiempo transcurrido en Ticks {miliSegundoTranscurridos} ");

            for (int i = 0; i < matrizAxB.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrizAxB.GetLength(1); j++)
                {
                    Console.Write($"{matrizAxB[i, j]}\t");
                }
            }
        }
    }
}
