/* Problem 3. Arrow
 */

using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = n * 2 - 1;
        int h1 = n - 1;
        Console.WriteLine(new string('.', (width - n) / 2) + new string('#', n) + new string('.', (width - n) / 2));
        string upLine = (new string('.', (width - n) / 2) + "#"+new string('.', n-2) + "#" + new string('.', (width - n) / 2));
        for (int i = 0; i < n - 2; i++) Console.WriteLine(upLine);
        Console.WriteLine(new string('#', (width - n) / 2+1) + new string('.',n-2)+ new string('#', (width - n) / 2+1));
        StringBuilder line = new StringBuilder();
        line.Append(new string('.',width));
        int pos = 1;
        for (int i = 0; i < n-1; i++)
        {
            line[pos] = '#';
            line[width-pos-1] = '#';
            Console.WriteLine(line);
            line[pos] = '.';
            line[width - pos - 1] = '.';
            pos++;
        }
    }
}