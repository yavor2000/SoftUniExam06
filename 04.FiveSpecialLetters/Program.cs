/* Problem 1. 
 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        
        char[] bukvi = { 'a', 'b', 'c', 'd', 'e' };
        int[] teglo = { 5, -12, 47, 7, -32 };
        int size = bukvi.GetLength(0);
        int count = 0;
        StringBuilder answer = new StringBuilder();
        StringBuilder toPrint = new StringBuilder();
        for (int d1 = 0; d1 < size; d1++)
            for (int d2 = 0; d2 < size; d2++)
                for (int d3 = 0; d3 < size; d3++)
                    for (int d4 = 0; d4 < size; d4++)
                        for (int d5 = 0; d5 < size; d5++)
                        {
                            int weight = 0;
                            answer.Remove(0, answer.Length);
                            toPrint.Remove(0, toPrint.Length);
                            toPrint.Append(bukvi[d1]); toPrint.Append(bukvi[d2]); toPrint.Append(bukvi[d3]); toPrint.Append(bukvi[d4]); toPrint.Append(bukvi[d5]);
                            if (answer.ToString().IndexOf(bukvi[d1]) < 0) answer.Append(bukvi[d1]);
                            if (answer.ToString().IndexOf(bukvi[d2]) < 0) answer.Append(bukvi[d2]);
                            if (answer.ToString().IndexOf(bukvi[d3]) < 0) answer.Append(bukvi[d3]);
                            if (answer.ToString().IndexOf(bukvi[d4]) < 0) answer.Append(bukvi[d4]);
                            if (answer.ToString().IndexOf(bukvi[d5]) < 0) answer.Append(bukvi[d5]);
                            
                            for (int k = 0; k < answer.Length; k++)
                                for (int i = 0; i < bukvi.GetLength(0); i++)
                                    if (answer[k] == bukvi[i]) { weight += (k + 1) * teglo[i]; break;}
                            
                            if (weight >= start && weight <= end)
                            {
                                toPrint.Append(' ');
                                Console.Write(toPrint);
                                count++;
                            }
                        }
        if (count == 0) Console.WriteLine("No");
    }

    static void antonia()
    {
        Console.WriteLine("Enter the total number");
        int n = int.Parse(Console.ReadLine());
        int nn = n * 2;
        int[] array = new int[nn];

        for (int i = 0; i < nn; i++) //този фор цикъл ти е само да въвдеш числата в масива array
        {
            array[i] = int.Parse(Console.ReadLine());
            //нищо друго не прави върху array в този фор цикъл
        }
        //ето тук вече array ти е зареден и може да работиш по него
        //задачата е да сумираш първите n числа от array, а послед да сумираш последните n числа
    }
}