namespace DailyLeetcode.Math.ConvertTemperature;
public class ConvertTemperature
{
    private static void Main()
    {
        double celsius = 36.50;

        foreach (var item in ConvertTemperatures(celsius))
            Console.WriteLine(item);
    }
    public static double[] ConvertTemperatures(double celsius)
    {
        double[] result = new double[2];

        result[0] = celsius + 273.15;
        result[1] = celsius * 1.80 + 32.00;

        return result;
    }
}

