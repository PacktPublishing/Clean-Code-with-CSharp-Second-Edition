using System;
using CH3.DependencyInjection;
using CH3.DesignForChange;
using CH3.InversionOfControl;
using Microsoft.Extensions.DependencyInjection;

namespace CH3;

class Program
{
    static void Main(string[] args)
    {
        var program = new Program();
        program.InterfaceOrientedProgrammingExample();
    }

    private static void DependencySetupExample()
    {
        // Create a service collection
        var serviceProvider = new ServiceCollection()
            .AddSingleton<ILogger, ConsoleLogger>() // Singleton lifetime.
            .AddTransient<ILogger, FileLogger>() // Transient lifetime.
            .BuildServiceProvider();

        // Resolve and use the Singleton logger.
        var singletonLogger = serviceProvider.GetRequiredService<ILogger>();
        singletonLogger.OutputMessage("This message is logged by the Singleton logger.");

        // Resolve and use the Transient logger.
        var transientLogger = serviceProvider.GetRequiredService<ILogger>();
        transientLogger.OutputMessage("This message is logged by the Transient logger.");

        // Check if both loggers are the the same instance.
        Console.WriteLine($"Is the Singletone logger the same instance as Transient logger? {ReferenceEquals(singletonLogger, transientLogger)}");
    }

    private void InterfaceOrientedProgrammingExample()
    {
        var mongoDb = new MongoDbConnection();
        var sqlServer = new SqlServerConnection();
        var db = new Database(mongoDb);
        db.OpenConnection();
        db.CloseConnection();
        db = new Database(sqlServer);
        db.OpenConnection();
        db.CloseConnection();
    }

    /// <summary>
    /// This method runs the DI Example.
    /// </summary>
    private void DependencyInject()
    {
        var logger = new TextFileLogger();
        var di = new Worker(logger);
        di.DoSomeWork(logger);
    }

    /// <summary>
    /// This method runs the IoC Exmple.
    /// </summary>
    private void InversionOfControl()
    {
        Container container = new Container();
        container.Configuration["message"] = "Hello World!";
        container.Register<ILogger>(delegate
        {
            return new TextFileLogger();
        });
        container.Register<Worker>(delegate
        {
            return new Worker(container.Create<ILogger>());
        });
    }

    private void MicrosoftIoCExample()
    {
        var serviceProvider = new ServiceCollection()
            .AddScoped<IMessageService, EmailService>() // Use AddScoped, AddTransient, or AddSingleton based on your needs.
            .AddScoped<NotificationService>()
            .BuildServiceProvider();

        var notificationService = serviceProvider.GetRequiredService<NotificationService>();
        notificationService.SendMessage("Hello, world!");
    }
}
