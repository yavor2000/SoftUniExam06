/* Problem 2. Odd Even Element
 */

using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        if (input.Length == 0) { Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No"); return; }
        string[] str = input.Split(' ');
        double[] num = new double[str.GetLength(0)];
        double oddSum = 0, oddMin = double.MaxValue, oddMax = double.MinValue;
        double evenSum = 0,  evenMin = double.MaxValue,  evenMax = double.MinValue;
        int evenCount=0;
        for (int i = 0; i < num.GetLength(0); i++)
        {
            num[i] = double.Parse(str[i]);
            if (i % 2 == 0)
            {
                oddSum += num[i];
                if (num[i] < oddMin) oddMin = num[i];
                if (num[i] > oddMax) oddMax = num[i];
            }
            else
            {
                evenCount++;
                evenSum += num[i];
                if (num[i] < evenMin) evenMin = num[i];
                if (num[i] > evenMax) evenMax = num[i];
            }
        }
        evenSum = Math.Round(evenSum, 2);
        evenMin = Math.Round(evenMin, 2);
        evenMax = Math.Round(evenMax, 2);
        oddSum = Math.Round(oddSum, 2);
        oddMin = Math.Round(oddMin, 2);
        oddMax = Math.Round(oddMax, 2);
        if (evenCount == 0) Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
            oddSum, oddMin, oddMax);
        else
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
            oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
    }
}