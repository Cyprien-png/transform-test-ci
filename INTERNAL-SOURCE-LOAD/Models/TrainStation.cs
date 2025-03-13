﻿namespace INTERNAL_SOURCE_LOAD.Models
{
    /// <summary>
    /// Represents a train station with its associated city and departures.
    /// </summary>
    /// <param name="Name">The name of the train station.</param>
    /// <param name="Departures">An array of departures from the train station.</param>
    [TableName("TrainStations")]
    public record TrainStation(string Name, List<Departure> Departures);
}
