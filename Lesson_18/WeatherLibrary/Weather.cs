namespace WeatherLibrary
{
    public class Weather
    {
        public string Location { get; set; }
        public int Temperature { get; set; }
        public int ProbabilityPrecipitation { get; set; }
        public int Humidity { get; set; }
        public int Wind { get; set; }

        public Weather() { }
        public Weather(string location, int temperature, int probabilityPrecipitation, int humidity, int wind)
        {
            Location = location;
            Temperature = temperature;
            ProbabilityPrecipitation = probabilityPrecipitation;
            Humidity = humidity;
            Wind = wind;
        }

        public void Print()
        {
            Console.WriteLine($"Месторасположение: {Location}\nТемпература: {Temperature}°C\nВероятность осадков: {ProbabilityPrecipitation}%\nВлажность: {Humidity}%\nВетер: {Wind} км/ч");
        }
        public string GeneralCharacteristicHumidity()
        {
            if (Humidity < 15)
            {
                return "cухо";
            }
            else if (Humidity > 15 && Humidity < 40)
            {
                return "увлажнитель воздуха не понадобится";
            }
            else if (Humidity > 40 && Humidity < 70)
            {
                return "сухость не побеспокоит";
            }
            else
            {
                return "сверхвлажно";
            }
        }
        public string GeneralCharacteristicPrecipitation()
        {
            if (ProbabilityPrecipitation < 20)
            {
                return "зонтик можно не брать";
            }
            else if (ProbabilityPrecipitation > 20 && ProbabilityPrecipitation < 50)
            {
                return "есть вероятность промокнуть";
            }
            else if (ProbabilityPrecipitation > 50 && ProbabilityPrecipitation < 70)
            {
                return "зонтик не будет лишним";
            }
            else
            {
                return "даже зонтик не поможет";
            }
        }

        public string GeneralCharacteristicsTemperature()
        {
            if (Temperature < -15)
            {
                return "собачий холод";
            }
            else if (Temperature > -15 && Temperature <= 0)
            {
                return "не май месяц";
            }
            else if (Temperature > 0 && Temperature < 10)
            {
                return "прохладно";
            }
            else if (Temperature > 10 && Temperature < 25)
            {
                return "тепло";
            }
            else
            {
                return "пекло";
            }
        }

        public string GeneralCharacteristicsWind()
        {
            if (Wind == 0)
            {
                return "безветренно";
            }
            else if (Wind > 0 && Wind < 10)
            {
                return "приятный ветерок";
            }
            else if (Wind > 10 && Wind < 20)
            {
                return "волосы лучше заплести";
            }
            else
            {
                return "крышесносный ветер";
            }
        }
    }
}