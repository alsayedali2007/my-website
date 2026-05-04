using System;

class Program
{
    static void Main()
    {
        double[] data = { 115, 182, 191, 31, 196, 1099, 5, 172, 10,
            179, 83, 21, 20, 21, 186, 177, 195, 193, 188, 199, 62, 109, 105, 183, 110 };
        int n = data.Length;

        Array.Sort(data);

        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += data[i];
        }
        double mean = sum / n;

        double median = data[n / 2];

        double q1 = data[n / 4];
        double q3 = data[3 * n / 4];
        double iqr = q3 - q1;

        double diffSum = 0;
        for (int i = 0; i < n; i++)
        {
            diffSum += Math.Pow(data[i] - mean, 2);
        }

        double variance = diffSum / n;
        double stdDev = Math.Sqrt(variance);

        Console.WriteLine("Mean: " + mean);
        Console.WriteLine("Median: " + median);
        Console.WriteLine("Range: " + (data[n - 1] - data[0]));
        Console.WriteLine("IQR: " + iqr);
        Console.WriteLine("Standard Deviation: " + stdDev);

        Console.WriteLine();
        Console.WriteLine("Outliers Check:");

        double lower = q1 - (1.5 * iqr);
        double upper = q3 + (1.5 * iqr);

        for (int i = 0; i < n; i++)
        {
            if (data[i] < lower || data[i] > upper)
            {
                Console.WriteLine("Outlier found: " + data[i]);
            }
        }

        Console.ReadLine();
    }
}