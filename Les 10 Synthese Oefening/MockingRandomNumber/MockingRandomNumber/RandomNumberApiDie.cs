namespace MockingRandomNumber;

public class RandomNumberApiDie : IDie
{
    private string url = "http://www.randomnumberapi.com/api/v1.0/random?min=1&max=6";

    public RandomNumberApiDie()
    {
    }

    public RandomNumberApiDie(string url)
    {
        this.url = url;
    }

    public int Roll()
    {
        using (var httpClient = new HttpClient())
        {
            var result = httpClient.GetStringAsync(url).GetAwaiter().GetResult();
            return int.Parse(result.Replace("[", "").Replace("]", ""));
        }
    }
}
