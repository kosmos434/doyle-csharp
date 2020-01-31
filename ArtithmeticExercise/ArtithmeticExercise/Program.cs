using System;
//
//  Program:    Programming Exercise
//  Developer:  Stuart Keese
//  Purpose:    Performs simple arithmetic on two numbers
//
class MainClass
{
    public static void Main(string[] args)
    {

        // declarations
        int numberOne, numberTwo, sum, difference, product, modulus;
        float quotient, average;


        // input
        Console.WriteLine("Please enter number 1");
        numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Number 1 is {0}", numberOne);
        Console.WriteLine("Please enter number 2");
        numberTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("Number 2 is {0}", numberTwo);
        Console.WriteLine();

        // calculations
        sum = numberOne + numberTwo;
        Console.WriteLine("Sum is {0}", sum);

        difference = numberOne - numberTwo;
        Console.WriteLine("Difference is {0}", difference);

        product = numberOne * numberTwo;
        Console.WriteLine("Product is {0}", product);

        quotient = (float)numberOne / numberTwo; //cast to float
        Console.WriteLine("Quotient is {0}", quotient);

        modulus = numberOne % numberTwo;
        Console.WriteLine("Remainder is {0}", modulus);

        average = (float)(numberOne + numberTwo) / 2; //cast to float
        Console.WriteLine("Average is {0}", average);

        Console.WriteLine();

    }
}