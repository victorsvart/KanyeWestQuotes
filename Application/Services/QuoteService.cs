using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Core.Models;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using System.Collections;
using Application.Interface;

namespace Application.Services
{
    public class QuoteService : IServiceQuote
    {


        public async Task<String> RunAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://api.kanye.rest");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var url = client.BaseAddress.ToString();
                    var newQuote = await GetQuote(url);
                    return string.Format("{0}: {1}", newQuote.Name, newQuote.Quote);
                }

            }
            catch (Exception ex)
            {
                return "Error";
            }
        }
        public async Task<Quotes> GetQuote(string path)
        {
            using (var client = new HttpClient())
            {
                Quotes quote = null;
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    quote = await response.Content.ReadFromJsonAsync<Quotes>();
                    quote.Name = "Kanye West";
                }
                return quote;
            }


        }

    }


}
