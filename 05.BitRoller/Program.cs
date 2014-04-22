/* Problem 5. Bit Roller
 */

using System;

class Program
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int maxBits = 19;

        r %= maxBits - 1;
        n <<= 64 - maxBits;
        n >>= 64 - maxBits;

        uint pillar = (n >> f) & 1;
        uint temp1 = (n >> f + 1) << f; //keep only bits left from pillar w/o the pillar
        uint temp2 = (f == 0) ? 0 : (n << 32 - f) >> 32 - f; //keep only bits right from pillar w/o the pillar
        uint temp3 = temp1 + temp2; //unite them without the pillar
        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(19, '0'));
        for (int i = 0; i < r; i++)
        {
            bool isOne = ((temp3 & 1) == 1);
            temp3 >>= 1;
            if (isOne) temp3 += (uint)(1 << (maxBits - 2));
            //Console.WriteLine(Convert.ToString(temp3, 2).PadLeft(maxBits, '0'));
        }
        temp1 = ((temp3 >> f) << f + 1); //move left side to its correct position
        temp1 += (uint)(pillar << f); //add the pillar
        temp1 += (f == 0) ? 0 : ((temp3 << 32 - f) >> 32 - f); //add the right side
        Console.WriteLine(temp1); //print the answer
        //Console.WriteLine(Convert.ToString(temp1, 2).PadLeft(maxBits, '0'));
    }
}