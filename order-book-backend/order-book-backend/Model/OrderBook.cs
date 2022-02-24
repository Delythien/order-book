﻿using System.Text.Json.Serialization;

namespace order_book_backend.Model
{
    public class OrderBookRequest
    {
        public string CurrencyPair { get; set; }
    }

    public class OrderBookResponse
    {
        public string ID { get; set; }
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long Timestamp { get; set; }
        public List<List<string>> Bids { get; set; }
        public List<List<string>> Asks { get; set; }
    }
}
