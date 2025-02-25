using System;
using System.Threading;

class CloudIntegrationExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Syncing with cloud...");
        Thread.Sleep(2000); // Simulate sync
        Console.WriteLine("Presentation saved to cloud!");

        Console.WriteLine("Loading from cloud...");
        Thread.Sleep(2000); // Simulate load
        Console.WriteLine("Presentation loaded from cloud.");
    }
}