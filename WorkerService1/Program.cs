using WorkerService1;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureWebJobs(webJobs =>
    {
     //   webJobs.AddAzureStorageCoreServices();
        webJobs.AddServiceBus();
    })
    .ConfigureServices(services =>
    {
       // services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
