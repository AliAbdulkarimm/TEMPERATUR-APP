using System;
using System.Globalization;

namespace Temperature.Data
{
    public record TemperatureList
    {

        public int Id { get; set; }
        public DateTime Datetime { get; set; }
        public string Location { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }

        public static TemperatureList ParseFromCSV(string line)
        {
            var columns = line.Split(',');
            if (columns[0] == "Datetime")
                return null;
            return new TemperatureList
            {
                Datetime = DateTime.Parse(columns[0]),
                Location = columns[1],
                Temperature = double.Parse(columns[2], CultureInfo.InvariantCulture),
                Humidity = double.Parse(columns[3])

            };
        }
    }
}
