﻿using System;
using System.Net.Http;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Kanye: {quote.KanyeQuote()}");

                Console.WriteLine($"Ron Swanson: {quote.RonSwansonQuote()}");
               
            }
        }
    }
}
