﻿using System;

namespace 迭代器
{
    class Program
    {
        static void Main(string[] args)
        {
            Primes primesFrom2To1000 = new Primes(2, 1000);
            foreach (long  i in primesFrom2To1000)
            {
                Console.Write($"{i}  ");
            }
        }
    }
}
