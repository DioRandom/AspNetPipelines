namespace AspNetPipelines.Core.Extensions
{
    public static class TemperatureExtensions
    {
        public static int ToFahrenheit(this int celsius)
        {
            return celsius * 9 / 5 + 32;
        }
    }
}
