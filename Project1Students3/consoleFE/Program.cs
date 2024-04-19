using System.Net;
using System.Text.Json;

namespace consoleFE;
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, User!\nPlease enter a name, color, strength, and dexterity separated by a space");
        string[] newStudRegistration = Console.ReadLine().Split(" ", 4);

        Console.Write("You entered: ");
        foreach (string x in newStudRegistration)
        {
            Console.Write($"{x} - ");
        }
        Console.WriteLine();
        HttpClient http = new HttpClient();

        HttpResponseMessage pc = await http.GetAsync($"https://localhost:7007/api/StudRegistration/register/{newStudRegistration[0]}/{newStudRegistration[1]}/{newStudRegistration[2]}/{newStudRegistration[3]}");


        if (pc.IsSuccessStatusCode && pc.StatusCode == HttpStatusCode.Created)
        {
            String res = await pc.Content.ReadAsStringAsync();
            Console.WriteLine(res);
        }
        else
        {
            Console.WriteLine("The request fialed!!!");
        }










    }
}
