using System;
using System.Collections.Generic;
using System.Text;

namespace MatrizAlejo
{
    internal class Calculadora
    {
        internal int[,] Multiplicar(int[,] matrizA, int[,] matrizB)
        {
            int filas = matrizA.GetLength(0);
            int columnas = matrizB.GetLength(1);
            int columnasA = matrizA.GetLength(1);

            int[,] matrizAxB = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                //fila columna B
                for (int j = 0; j < columnas; j++)
                {
                    //columnas de la matriz A
                    int acomulador = 0;
                    for (int k = 0; k < columnasA; k++)
                    {
                        acomulador += matrizA[i, k] * matrizB[k, j];
                    }
                    matrizAxB[i, j] = acomulador;
                }
            }
            return matrizAxB;
        }


        internal int[,] CrearMatriz(int fila, int columna)
        {
            var generador = new Random();
            int[,] matriz = new int[fila, columna];
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    matriz[i, j] = generador.Next(10, 99);
                }
            }
            return matriz;
        }
    }
}