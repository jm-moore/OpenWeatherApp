using Newtonsoft.Json.Linq;

// API Key = 2f8f253ca1d0b89568a167e2b320e678

var client = new HttpClient();

Console.WriteLine($"Welcome to the Open Weather API!\nPlease enter your API key:");
var api_key = Console.ReadLine();

Console.WriteLine("Enter the city that you want the current forecast of:");
var city_name = Console.ReadLine().ToLower();

var URL = $"https://api.openweathermap.org/data/2.5/weather?q={city_name}&appid={api_key}&units=imperial";

var weather = client.GetStringAsync(URL).Result;

var formattedResponseMain = JObject.Parse(weather);
var formattedResponseTemp = formattedResponseMain["main"]["temp"];

Console.WriteLine($"\n{formattedResponseTemp} degrees fahrenheit.");