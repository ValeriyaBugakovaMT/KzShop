using KzShop.BussinesLogic;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Product>();
    })
    .Build();

await host.RunAsync();
