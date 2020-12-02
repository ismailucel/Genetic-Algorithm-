using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int[] gene1 = new int[4];
            int[] gene2 = new int[4];
            int[] gene3 = new int[4];
            int[] wanted = new int[4];
            Console.WriteLine(" Enter the gene sequence one by one: ");
            for (int k = 0; k < 4; k++)
            {
                wanted[k] = Convert.ToInt32(Console.ReadLine());
            }
            Random rnd = new Random();
            for (; ; )
            {
            Head:
                Console.WriteLine("\n {0}. Iteration", count);
                for (int i = 0; i < 4; i++)
                {
                    gene1[i] = rnd.Next(0, 2);
                    gene2[i] = rnd.Next(0, 2);
                }
                cross(gene1, gene2, gene3);

                mutation(gene3);
                count++;

                if (comparison(gene3, wanted) == true)
                {
                    Console.Write("\n gene 1: ");
                    for (int i = 0; i < gene1.Length; i++)
                    {
                        Console.Write(gene1[i]);
                    }
                    Console.Write("\n gene 2: ");
                    for (int i = 0; i < gene1.Length; i++)
                    {
                        Console.Write(gene2[i]);
                    }
                    Console.Write("\n The mutated gene: ");
                    for (int i = 0; i < gene1.Length; i++)
                    {
                        Console.Write(gene3[i]);
                    }
                    Console.Write("\n The wanted gene: ");
                    for (int i = 0; i < gene1.Length; i++)
                    {
                        Console.Write(wanted[i]);
                    }
                    Console.WriteLine("\n gene has mutated{0} times. ", count - 1);
                    break;
                }
                else
                {
                    Console.Write("\n gene 1: ");
                    for (int i = 0; i < gene1.Length; i++)
                    {
                        Console.Write(gene1[i]);
                    }
                    Console.Write("\n gene 2: ");
                    for (int i = 0; i < gene1.Length; i++)
                    {
                        Console.Write(gene2[i]);
                    }
                    Console.Write("\n Wanted gene: ");
                    for (int i = 0; i < gene1.Length; i++)
                    {
                        Console.Write(wanted[i]);
                    }
                    Console.Write("\n gene 2 : ");
                    for (int i = 0; i < gene1.Length; i++)
                    {
                        Console.Write(gene2[i]);
                    }
                    Console.Write("\n The mutated gene: ");
                    for (int i = 0; i < gene1.Length; i++)
                    {
                        Console.Write(gene3[i]);
                    }
                    goto Head;
                }

            }
        }
        private static void cross(int[] gene1, int[] gene2, int[] gene3)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i < 2)
                {
                    gene3[i] = gene1[i];
                }
                else
                {
                    gene3[i] = gene2[i];
                }
            }
        }
        private static void mutation(int[] gene3)
        {
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                gene3[i] = rnd.Next(0, 2);
            }
        }
        static bool comparison(int[] gene3, int[] wanted)
        {
            bool isEqual = true;
            for (int i = 0; i < 4; ++i)
            {
                if (gene3[i] != wanted[i])
                {
                    isEqual = false;
                }

            }
            return isEqual;
        }
    }
}
