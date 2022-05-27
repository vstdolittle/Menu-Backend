using Dolittle.SDK;
using Dolittle.SDK.Tenancy;
using Microsoft.Extensions.Hosting;

public static class Program 
{
    public static void main(string[] args)
    {
        var host = Host.CreateDefaultBuilder()
            .UseDolittle()
            .Build();

        host.Run();
    }
}