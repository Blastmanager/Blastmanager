using Blastmanager;
using Blastmanager.Contractor.Entities.Interfaces;

var builder = Host.CreateApplicationBuilder(args);

// Register BlastManager clients
builder.Services.AddBlastManager(config =>
{
    config.Username = builder.Configuration["BlastManager:Username"];
    config.Password = builder.Configuration["BlastManager:Password"];
    // Change the default service lifetime.
    // Default is Scoped
    //config.ServiceLifetime = ServiceLifetime.Scoped;
});

var host = builder.Build();

// Get a client
var scope = host.Services.CreateScope();
var client = scope.ServiceProvider.GetRequiredService<IContractorClient>();
// Retrieve projects
var projects = await client.GetProjectsAsync(true);