﻿using System;

namespace begin31
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var tf = int.Parse(Console.ReadLine());
            

            var resulttc = (tf - 32) * 5 / 9;
            Console.WriteLine(resulttc);
            
        }
    }
}