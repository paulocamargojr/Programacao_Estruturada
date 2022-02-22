using System;
using System.Collections.Generic;

namespace Programacao_Estruturada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            numeros = obterValores();
            Array.Sort(numeros);
            int maior = numeros[0];
            int menor;
            obterMaior(ref maior, numeros);
            obterMenor(out menor, numeros);
            obterMedia(numeros);
            obterTresMaiores(numeros);
            obterNegativos(numeros);
            mostrarValores(numeros);
            removerValor(numeros);
            Console.ReadKey();
        }
        #region metodos
        static int[] obterValores()
        {
            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Insira o numero na posicao " + Convert.ToInt32(i + 1));
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numeros;
        }

        static void obterMaior(ref int maior, int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                    maior = numeros[i];
            }
            Console.WriteLine("O maior valor é " + maior);
        }

        static void obterMenor(out int menor, int[] numeros)
        {
            menor = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (menor > numeros[i])
                {
                    menor = numeros[i];
                }
            }
            Console.WriteLine("O menor valor é " + menor);
        }

        static void obterMedia(int[] numeros)
        {
            float media = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                media += numeros[i];
            }
            media /= numeros.Length;
            Console.WriteLine("A media é " + media);
        }

        static void obterTresMaiores(int[] numeros)
        {
            Console.Write("Três maiores valores são : ");
            for (int i = numeros.Length - 1; i > 6; i--)
            {
                Console.Write(numeros[i]);
                if (i > 7)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

        static void obterNegativos(int[] numeros)
        {
            int contadorNegativos = 0;
            Console.Write("Os numeros negativos são: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                    Console.Write(numeros[i] + " ");
                contadorNegativos++;
            }
            if (contadorNegativos == 0)
                Console.WriteLine("Sem valores negativos!");
            Console.WriteLine();
        }

        static void mostrarValores(int[] numeros)
        {

            Console.Write("Valores: ");
            for (int i = 0; i < numeros.Length; i++)
            {

                Console.Write(numeros[i] + " ");

            }
            Console.WriteLine();
        }

        static void removerValor(int[] numeros)
        {
            List<int> list = new List<int>(numeros);
            list.RemoveAt(0);
            Console.Write("Depois de remover: ");
            for (int i = 0; i < list.Count; i++)
            {

                Console.Write(list[i] + " ");

            }
        }
        #endregion
    }
}
