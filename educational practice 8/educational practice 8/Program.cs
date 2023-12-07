using System;
using System.IO;
using System.Text.Json;
using System.Web.Profile;
using RestSharp;


class Program
{ 
    static string apiKey = "91dc6b8972482eaa7daf5c3b445f1e3e";
    private static string defaultCity = "defaultCity.json";
    
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите");
            Console.WriteLine("1. Посмотреть погоду города по умолчанию");
            Console.WriteLine("2. Посмотреть погоду города по названию");
            Console.WriteLine("3. Сменить город по умолчанию");
            Console.WriteLine("4. Выход");
            Console.WriteLine();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string defaulCity = loadDefaultCity();
                    displayWeather(defaulCity);
                    break;
                case "2":
                    string city = getCity(args);
                    displayWeather(city);
                    break;
                case "3":
                    changeDefaultCity();
                    break;
                case "4":
                    Console.WriteLine("До свидания!");
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                    break;
            }
        }
    }

    static string getCity(string[] args)
    {
        string city = defaultCity;
        if (args.Length > 0)
        {
            city = args[0];
        }
        else
        {
            Console.Write("Введите город: ");
            string userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                city = userInput;
            }
        }
        return city;
    }
    static void displayWeather(string city)
    {
        string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={apiKey}";

        var client = new RestClient(apiUrl);
        var request = new RestRequest();

        var response = client.Execute<WeatherResponse>(request);

        if (response.IsSuccessful)
        {
            WeatherResponse weather = response.Data;
            Console.WriteLine($"Погода в городе {city}: ");
            Console.WriteLine($"Температура: {weather.Main.Temp} C");
            Console.WriteLine($"Влажность: {weather.Main.Humidity}%");
            Console.WriteLine($"Скорость ветра: {weather.Wind.Speed} м/c");
            string temp = Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"Ошибка при получении данных о погоде для города {city}");
            Console.WriteLine($"Код ошибки: {response.StatusCode}");
            string temp = Console.ReadLine();
        }
    }

    static void changeDefaultCity()
    {
        Console.Write("Введите новый год по умолчанию: ");
        string city = Console.ReadLine();
        if (!string.IsNullOrEmpty(city))
        {
            saveDefaultCity(city);
            Console.WriteLine($"Город по умолчанию изменен на: {city}");
            string temp = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Введено некорректное значение.");
            string temp = Console.ReadLine();
        }
    }
    static void saveDefaultCity(string city)
    {
        string json = JsonSerializer.Serialize(city);
        File.WriteAllText("defaultCity.json", json);
    }

    static string loadDefaultCity()
    {
        if (File.Exists("defaultCity.json"))
        {
            string json = File.ReadAllText("defaultCity.json");
            return JsonSerializer.Deserialize<string>(json);
        }
        return "Tomsk";
    }

    public class WeatherResponse
    {
        public MainInfo Main { get; set; }
        public WindInfo Wind { get; set; }
    }

    public class MainInfo
    {
        public double Temp { get; set; }
        public double Humidity { get; set; }
    }

    public class WindInfo
    {
        public double Speed { get; set; }
    }
}