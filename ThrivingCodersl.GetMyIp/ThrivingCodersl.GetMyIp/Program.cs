using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace ThrivingCodersl.GetMyIp
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new HttpClient();
//            httpClient.BaseAddress = new Uri("http://ip.jsontest.com");

            var httpResponse = httpClient.GetAsync("http://ip.jsontest.com");
            var task = httpResponse.Result.Content.ReadAsAsync<IpResponse>();
            
            var ipResponse = task.Result;
            Console.WriteLine(ipResponse.ip);
            Console.ReadKey();

        }
    }
}
