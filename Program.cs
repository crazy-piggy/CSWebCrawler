using System;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        public static void main(string[] args)
        {
            string str = SendHttpPost("https://www.baidu.com", "");
            Console.WriteLine(str);
            Console.ReadKey();
        }
        public static string SendHttpPost(string url, string paraJsonStr)
        {
            WebClient webClient
        }
    }
}
