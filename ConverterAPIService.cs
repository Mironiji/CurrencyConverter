using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text.Json;

using System.Diagnostics;
using static System.Resources.ResXFileRef;

namespace CurrencyConverter
{
    internal class ConverterAPIService
    {
        private static readonly HttpClient httpClient = new()
        {
            Timeout = TimeSpan.FromSeconds(10)
        };

        public ConverterAPIService()
        {

        }

        public record ConversationResult(
            decimal amount,
            decimal Rate,
            string? Date);

        public record Rate(
            decimal rate,
            string? date);

        public record Currency(
            string iso_code,
            string name);

        public async Task<ConversationResult> ConvertAsync(
            decimal amount,
            string from,
            string to)
        {
            if (from == to)
                return new ConversationResult(amount, 1m, null);

            string url =
                $"https://api.frankfurter.dev/v2/rate/{from}/{to}";

            string json =
                await httpClient.GetStringAsync(url);

            var data = JsonSerializer.Deserialize<Rate>(json)!;

            if (data == null)
                throw new Exception("HTTP Error 500");

            decimal convertered = Math.Round(amount * data.rate, 2);

            Debug.WriteLine($"{amount}, {data.rate}, {convertered}");

            return new ConversationResult(
                convertered,
                data.rate,
                data.date);
        }

        public async Task<Currency[]> GetCurrencies()
        {
            string url =
                $"https://api.frankfurter.dev/v2/currencies";

            string json =
                await httpClient.GetStringAsync(url);

            var currencies = JsonSerializer.Deserialize<Currency[]>(json)!;

            if (currencies == null)
                throw new Exception("HTTP Error 500");

            foreach ( var (a, b) in currencies)
            {
                Debug.WriteLine($"{a} : {b}");
            }

            return currencies;
        }
        private class RateResponce
        {
            [JsonPropertyName("rate")]
            public decimal Rate { get; set; }
            [JsonPropertyName("date")]
            public string? Date { get; set; }
        }
    }
}
