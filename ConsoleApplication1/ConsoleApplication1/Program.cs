using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379"); 
            ISubscriber sub = redis.GetSubscriber();
            //IDatabase db = redis.GetDatabase();
            //string value = db.StringGet("recent_popular_searchs");
            //Console.WriteLine(value); // writes: "abcdefg"
            //Console.WriteLine("data: ");
            sub.Publish("messages", "hello"); 
            //sub.Subscribe("messages", (channel, message) =>
            //{
            //    Console.WriteLine((string)message);
            //});
           
            Console.ReadLine();
        }
    }
}
