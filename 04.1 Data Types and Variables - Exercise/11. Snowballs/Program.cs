using System;
using System.Numerics;

namespace SnowballCompetition
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            BigInteger bestValue = BigInteger.Zero;
            string result = string.Empty;

            while (count-- > 0)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                int baseValue = snow / time;
                BigInteger currentValue = BigInteger.Pow(baseValue, quality);

                if (currentValue > bestValue)
                {
                    bestValue = currentValue;
                    result = $"{snow} : {time} = {currentValue} ({quality})";
                }
            }

            Console.WriteLine(result);
        }
    }
}