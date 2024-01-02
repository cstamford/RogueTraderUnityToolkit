using NUnit.Framework;
using RogueTraderUnityToolkit.Core;
using System.Collections.Concurrent;
using System.Text;

namespace RogueTraderUnityToolkit.Tests;

public class FastTextWriterTests
{
    [Test]
    public void FloatingPointAccuracy()
    {
        ConcurrentBag<float> ourSums = [];
        ConcurrentBag<float> ourMaxes = [];

        ConcurrentBag<float> theirSums = [];
        ConcurrentBag<float> theirMaxes = [];

        Parallel.ForEach(Partitioner.Create(
            CalculateStartingIntegerForPrecision9(),
            BitConverter.SingleToInt32Bits(1.0f)),
            (range) =>
        {
            int count = 0;

            float ourDiffSum = 0.0f;
            float ourDiffMax = 0.0f;

            float theirDiffSum = 0.0f;
            float theirDiffMax = 0.0f;

            using MemoryStream stream = new();
            Span<byte> buffer = stackalloc byte[64];

            bool negative = false;

            // step i by a constant each time, otherwise there's way too much work
            for (int i = range.Item1; i < range.Item2; i += 33, ++count, negative = !negative)
            {
                float f = BitConverter.Int32BitsToSingle(i) * (negative ? -1 : 1);

                stream.Position = 0;
                FastTextWriter writer = new(stream);
                writer.Write(f);

                int len = (int)stream.Position;
                stream.Position = 0;

                Assert.That(stream.Read(buffer[..len]), Is.EqualTo(len));

                string ourStr = Encoding.ASCII.GetString(buffer[..len]);
                string theirStr = $"{f:F9}";

                float ourBackToFloat = Convert.ToSingle(ourStr);
                float ourDiff = Math.Abs(f - ourBackToFloat);
                ourDiffSum += ourDiff;
                ourDiffMax = Math.Max(ourDiffMax, ourDiff);

                float theirBackToFloat = Convert.ToSingle(theirStr);
                float theirDiff = Math.Abs(f - theirBackToFloat);
                theirDiffSum += theirDiff;
                theirDiffMax = Math.Max(theirDiffMax, theirDiff);

                Assert.That(ourDiff, Is.LessThanOrEqualTo(1e-6));
            }

            ourSums.Add(ourDiffSum / count);
            ourMaxes.Add(ourDiffMax);

            theirSums.Add(theirDiffSum / count);
            theirMaxes.Add(theirDiffMax);
        });

        float ourDiffSum = ourSums.Sum();
        float ourDiffMax = ourMaxes.Max();

        float theirDiffSum = theirSums.Sum();
        float theirDiffMax = theirMaxes.Max();

        Console.WriteLine($"avg:");
        Console.WriteLine($"     {ourDiffSum:F9} (us)");
        Console.WriteLine($"     {theirDiffSum:F9} (them)");
        Console.WriteLine();

        Console.WriteLine($"max:");
        Console.WriteLine($"     {ourDiffMax:F9} (us)");
        Console.WriteLine($"     {theirDiffMax:F9} (them)");
        Console.WriteLine();

        Assert.That(ourDiffSum, Is.LessThanOrEqualTo(1e-6));
        Assert.That(ourDiffMax, Is.LessThanOrEqualTo(1e-6));
    }

    private static int CalculateStartingIntegerForPrecision9()
    {
        // The precision of 1e-9 in binary is 2^-log2(1e9)
        int precisionExponent = (int)Math.Ceiling(Math.Log(1e9, 2));

        // The exponent for float is biased by 127
        int exponentBits = 127 - precisionExponent;

        // Construct the bit pattern for the smallest float with the desired precision
        // Since we want the smallest number greater than 0, the mantissa is 0
        return exponentBits << 23;
    }
}
