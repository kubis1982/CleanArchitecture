namespace CleanArchitecture.Presentation.Console
{
    using MongoDB.Driver;
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var database = client.GetDatabase("CleanArchitectureDb");
        }
    }
}
