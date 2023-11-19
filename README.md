# Blastmanager
Package for public APIs

## Install
```
Package here
```

## Setup
Best way to setup the client is through the host builder. This way the client will configure its HttpClients from the IHttpClientFactory and add all the needed clients into the DI as scoped services.

Minimal setup of clients
```
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();

builder.Host.AddBlastManager(configure =>
{
    configure.Username = builder.Configuration["BlastManager:Username"]!;
    configure.Password  = builder.Configuration["BlastManager:Password"]!;
});

var app = builder.Build();
app.Run();
```
