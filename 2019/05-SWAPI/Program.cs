using _05_SWAPI.Data;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _05_SWAPI
{
    class Program
    {
        static HttpClient client = new HttpClient();

        static async Task<Person> GetPersonAsync(string personId)
        {
            Person person = null;
            HttpResponseMessage response = await client.GetAsync($"people/{personId}");
            if (response.IsSuccessStatusCode)
            {
                person = await response.Content.ReadAsAsync<Person>();
                
            }
            return person;
        }

        static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://swapi.co/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Get the product
                Person person = await GetPersonAsync("1");
                Console.WriteLine($"{person.ToString()}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
