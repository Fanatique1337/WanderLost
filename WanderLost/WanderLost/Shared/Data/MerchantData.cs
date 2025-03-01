﻿namespace WanderLost.Shared.Data;

public class MerchantData
{
    public string Name { get; init; } = string.Empty;
    public string Region { get; init; } = string.Empty;
    public List<Item> Cards { get; init; } = new();
    public List<Item> Rapports { get; init; } = new();
    public List<string> Tradeskills { get; init; } = new();
    public int SortOrder { get; init; }
    public int[] SpawnTimes { get; init; } = new int[7];
}
