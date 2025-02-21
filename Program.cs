string city = Console.ReadLine();

const string KEY = "1a798bad05f71da803740b14e9d0d166";

using (HttpClient client = new())
{
    try
    {
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={KEY}";
        HttpResponseMessage responce = await client.GetAsync(url);

        if(responce.IsSuccessStatusCode)
        {
            string result = await responce.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine($"Error: {responce.StatusCode}");
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Exception: {ex.Message}");
    }
}