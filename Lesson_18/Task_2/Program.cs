using WeatherLibrary;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Город: ");
            string location = Console.ReadLine();
            Console.Write("Температура: ");
            int temp = int.Parse(Console.ReadLine());
            Console.Write("Вероятность осадков: ");
            int precipit = int.Parse(Console.ReadLine());
            Console.Write("Влажность: ");
            int humi = int.Parse(Console.ReadLine());
            Console.Write("Ветер: ");
            int wind = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВот погода на сегодня:");
            Weather weather = new Weather(location, temp, precipit, humi, wind);
            weather.Print();
            string temperatureCH = weather.GeneralCharacteristicsTemperature();
            string windCH = weather.GeneralCharacteristicsWind();
            string humidityCH = weather.GeneralCharacteristicHumidity();
            string precipitationCH = weather.GeneralCharacteristicPrecipitation();
            Console.WriteLine($"А если быть точнее, то сегодня {temperatureCH}, {windCH}, {precipitationCH}, {humidityCH}.");
        }
    }
}