﻿using CsvHelper.Configuration;

namespace StarWarsAPI.DataModels;

public class VehicleDataModel : IDataModel
{
    public string name { get; set; }
    public string model { get; set; }
    public string manufacturer { get; set; }
    public string cost_in_credits { get; set; }
    public string length { get; set; }
    public string max_atmosphering_speed { get; set; }
    public string crew { get; set; }
    public string passengers { get; set; }
    public string cargo_capacity { get; set; }
    public string consumables { get; set; }
    public string vehicle_class { get; set; }
    public List<string> pilots { get; set; }
    public List<string> films { get; set; }
    public DateTime created { get; set; }
    public DateTime edited { get; set; }
    public string url { get; set; }
    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Model: {model}");
        Console.WriteLine($"Manufacturer:  {manufacturer}");
        Console.WriteLine($"Cost in Credits: {cost_in_credits}");
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"MAX Atmosphering Speed: {max_atmosphering_speed}");
        Console.WriteLine($"Crew: {crew}");
        Console.WriteLine($"Passengers: {passengers}");
        Console.WriteLine($"Cargo Capacity: {cargo_capacity}");
        Console.WriteLine($"Consumables: {consumables}");
        Console.WriteLine($"Vehicle Class: {vehicle_class}");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }
    public string Films => films != null && films.Any() ? string.Join("; ", films.Select(a => a)) : string.Empty;
    public string Pilots => pilots != null && pilots.Any() ? string.Join("; ", pilots.Select(a => a)) : string.Empty;
}

// Map the data model to the csv file
public class VehicleDataModelMap : ClassMap<VehicleDataModel>
{
    public VehicleDataModelMap()
    {
        Map(m => m.name);
        Map(m => m.model);
        Map(m => m.manufacturer);
        Map(m => m.cost_in_credits);
        Map(m => m.length);
        Map(m => m.max_atmosphering_speed);
        Map(m => m.crew);
        Map(m => m.passengers);
        Map(m => m.cargo_capacity);
        Map(m => m.consumables);
        Map(m => m.vehicle_class);

        Map(m => m.Films);
        Map(m => m.Pilots);

        Map(m => m.url);
        Map(m => m.created);
        Map(m => m.edited);
    }
}
