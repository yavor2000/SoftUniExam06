/* Problem 1. Exam Schedule
 */

using System;

class Program
{
    static void Main()
    {
        int hour = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int durH = int.Parse(Console.ReadLine());
        int durM = int.Parse(Console.ReadLine());

        int ansM = durM + minute;
        int ansH = hour + durH;
        if (ansM >= 60) { ansH++; ansM -= 60; }

        if (hour % 12 == 0)
        {
            if ((ansH / 12) % 2 == 0) { partOfDay = (partOfDay == "AM") ? "PM" : "AM"; }
        }
        else
        {
            if ((ansH / 12) % 2 != 0) { partOfDay = (partOfDay == "AM") ? "PM" : "AM"; }
        }
        ansH = (ansH % 12 == 0) ? 12 : ansH % 12;
        Console.WriteLine("{0}:{1}:{2}", ansH.ToString().PadLeft(2, '0'), ansM.ToString().PadLeft(2, '0'), partOfDay);
    }
}