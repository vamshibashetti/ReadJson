using System.Security.AccessControl;
using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ReadJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var configurationBuilder = new ConfigurationBuilder ();
            configurationBuilder.SetBasePath (Directory.GetCurrentDirectory ());
            configurationBuilder.AddJsonFile ("testdata.json", optional : true, reloadOnChange : true);
            IConfigurationRoot configuration = configurationBuilder.Build ();
            //connectionstring method is default method
           Console.WriteLine (configuration.GetConnectionString ("SqlDb"));
            Console.WriteLine (configuration.GetConnectionString ("OracleDb"));
            Console.WriteLine (configuration.GetConnectionString ("MangoDb"));
            Console.WriteLine (configuration.GetSection ("ApplicationUnderTest:QA").Value);
            Console.WriteLine (configuration.GetSection ("ApplicationUnderTest:Stage").Value);
            Console.WriteLine (configuration.GetSection ("ApplicationUnderTest:Prod").Value);

            Console.WriteLine (configuration.GetSection ("ConnectionStrings:SqlDb").Value);
            Console.WriteLine (configuration.GetSection ("ConnectionStrings:OracleDb").Value);
            Console.WriteLine (configuration.GetSection ("ConnectionStrings:MangoDb").Value);

            Console.WriteLine (configuration.GetSection ("ConnectionStrings")["SqlDb"]);
            Console.WriteLine (configuration.GetSection ("ConnectionStrings")["OracleDb"]);
            Console.WriteLine (configuration.GetSection ("ConnectionStrings")["MangoDb"]);
            
        }



    }
}
