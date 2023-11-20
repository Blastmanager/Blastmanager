﻿using System.Text.Json;
using Blastmanager.Contractor.Entities.Constants;
using Blastmanager.Contractor.Entities.Interfaces;
using Blastmanager.Contractor.Entities.Response;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Blastmanager.Contractor.Entities;

/// <inheritdoc />
public class ContractorClient(IOptions<ContractorOption> options,
                HttpClient client,
                ILogger<ContractorClient> logger)
        : IContractorClient
{
    private readonly HttpClient _client = client;
    private readonly ILogger<ContractorClient> _logger = logger;
    private readonly IOptions<ContractorOption> _options = options;

    /// <inheritdoc />
    public async Task<GetProjectsResponse[]> GetProjectsAsync(bool onlyActive,
            CancellationToken cancellationToken = default)
    {
        var response = await _client.GetAsync($"{ApiUri.GetProjects}?onlyActive={onlyActive}", cancellationToken);
        response.EnsureSuccessStatusCode();
        var value = JsonSerializer.Deserialize<GetProjectsResponse[]>(
                await response.Content.ReadAsStringAsync(cancellationToken));
        return value!;
    }

    /// <inheritdoc />
    public async Task<BlastReportsResponse[]> GetBlastReportsByBlastDateAsync(DateTime from, DateTime to,
            CancellationToken cancellationToken = default)
    {
        if (from > to) throw new ArgumentException("From date must be before to date");
        var response = await _client.GetAsync($"{ApiUri.GetBlastReportsByBlastDate}" +
                                              $"?from={from:YYYY-MM-DDTHH:mm:ss}&to={to:YYYY-MM-DDTHH:mm:ss}",
                cancellationToken);
        response.EnsureSuccessStatusCode();
        await response.Content.ReadAsStringAsync(cancellationToken);
        var value = JsonSerializer.Deserialize<BlastReportsResponse[]>(
                        await response.Content.ReadAsStringAsync(cancellationToken));
        return value!;
    }

    /// <inheritdoc />
    public async Task<BlastReportsResponse[]> GetBlastReportsByLastChangedAsync(DateTime from, DateTime to,
            CancellationToken cancellationToken = default)
    {
        if (from > to) throw new ArgumentException("From date must be before to date");
        var response = await _client.GetAsync($"{ApiUri.GetBlastReportsByLastChanged}" +
                                              $"?from={from:YYYY-MM-DDTHH:mm:ss}&to={to:YYYY-MM-DDTHH:mm:ss}",
                cancellationToken);
        response.EnsureSuccessStatusCode();
        var value =JsonSerializer.Deserialize<BlastReportsResponse[]>(
                        await response.Content.ReadAsStringAsync(cancellationToken));
        return value!;
    }

    /// <inheritdoc />
    public async Task<GetMisfireResponse[]> GetMisfiresByLastChangedAsync(DateTime from, DateTime to,
            CancellationToken cancellationToken = default)
    {
        if (from > to) throw new ArgumentException("From date must be before to date");
        var response = await _client.GetAsync($"{ApiUri.GetMisFiresByLastChanged}" +
                                              $"?from={from:YYYY-MM-DDTHH:mm:ss}&to={to:YYYY-MM-DDTHH:mm:ss}",
                cancellationToken);
        response.EnsureSuccessStatusCode();
        
        var value = JsonSerializer.Deserialize<GetMisfireResponse[]>(
                        await response.Content.ReadAsStringAsync(cancellationToken));
        return value!;
    }

    /// <inheritdoc />
    public async Task<GetMisfireResponse[]> GetMisfiresByFoundDateAsync(DateTime from, DateTime to,
            CancellationToken cancellationToken = default)
    {
        if (from > to) throw new ArgumentException("From date must be before to date");
        var response = await _client.GetAsync($"{ApiUri.GetMisFiresByFoundDate}" +
                                              $"?from={from:YYYY-MM-DDTHH:mm:ss}&to={to:YYYY-MM-DDTHH:mm:ss}",
                cancellationToken);
        response.EnsureSuccessStatusCode();
        var value = JsonSerializer.Deserialize<GetMisfireResponse[]>(
                        await response.Content.ReadAsStringAsync(cancellationToken));
        return value!;
    }
}