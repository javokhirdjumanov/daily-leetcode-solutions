namespace DailyLeetcode.Maths.Easy;
public sealed class ConvertTemperatures
{
    public static double[] ConvertTemperaturess(double celsius)
    {
        double[] result = new double[2];

        result[0] = celsius + 273.15;
        result[1] = celsius * 1.80 + 32.00;

        return result;
    }
}
