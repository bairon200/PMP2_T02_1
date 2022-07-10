using Newtonsoft.Json;
using PMP2_T02.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PMP2_T02.controller
{
    public class paises
    {
        

            public async static Task<List<contructor.Root>> ObtenerAmerica()
            {
                List<contructor.Root> listapaises = new List<contructor.Root>();
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync("https://restcountries.com/v3.1/region/Americas");
                    if (response.IsSuccessStatusCode)
                    {
                        var contenido = response.Content.ReadAsStringAsync().Result;
                        listapaises = JsonConvert.DeserializeObject<List<contructor.Root>>(contenido);
                    }
                }
                return listapaises;
            }

            public async static Task<List<contructor.Root>> ObtenerEuropa()
            {
                List<contructor.Root> listapaises = new List<contructor.Root>();
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync("https://restcountries.com/v3.1/region/Europe");
                    if (response.IsSuccessStatusCode)
                    {
                        var contenido = response.Content.ReadAsStringAsync().Result;
                        listapaises = JsonConvert.DeserializeObject<List<contructor.Root>>(contenido);
                    }
                }
                return listapaises;
            }

            public async static Task<List<contructor.Root>> ObtenerAfrica()
            {
                List<contructor.Root> listapaises = new List<contructor.Root>();
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync("https://restcountries.com/v3.1/region/Africa");
                    if (response.IsSuccessStatusCode)
                    {
                        var contenido = response.Content.ReadAsStringAsync().Result;
                        listapaises = JsonConvert.DeserializeObject<List<contructor.Root>>(contenido);
                    }
                }
                return listapaises;
            }

            public async static Task<List<contructor.Root>> ObtenerOceania()
            {
                List<contructor.Root> listapaises = new List<contructor.Root>();
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync("https://restcountries.com/v3.1/region/Oceania");
                    if (response.IsSuccessStatusCode)
                    {
                        var contenido = response.Content.ReadAsStringAsync().Result;
                        listapaises = JsonConvert.DeserializeObject<List<contructor.Root>>(contenido);
                    }
                }
                return listapaises;
            }
            public async static Task<List<contructor.Root>> ObtenerAsia()
            {
                List<contructor.Root> listapaises = new List<contructor.Root>();
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync("https://restcountries.com/v3.1/region/Asia");
                    if (response.IsSuccessStatusCode)
                    {
                        var contenido = response.Content.ReadAsStringAsync().Result;
                        listapaises = JsonConvert.DeserializeObject<List<contructor.Root>>(contenido);
                    }
                }
                return listapaises;
            }

        
    }
}
