// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math
using System;

class Program
{
    public static void Main(string[] args)
    {
        int sideA;
        int sideB;
        int sideC;

        //Input 
        Console.WriteLine("This program checks the type of triangle.");
        Console.WriteLine("");
        Console.Write("Enter side A: ");
        sideA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Enter side B: ");
        sideB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Enter side C: ");
        sideC = Convert.ToInt32(Console.ReadLine());

        //Process
        if (sideA == sideB && sideB == sideC)
            Console.WriteLine("Triangle is an equilateral.");
        else if (sideA == sideB || sideB == sideC || sideA == sideC)
            Console.WriteLine("Triangle is an isosceles");
        else
            Console.WriteLine("Triangle is a scalene.");

        Console.WriteLine("\nDone.");
    }
}