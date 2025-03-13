﻿using System.Diagnostics;

namespace INTERNAL_SOURCE_LOAD.Models
{
    /// <summary>
    /// Represents a train departure, including details of the journey and train schedule.
    /// </summary>
    /// <param name="DepartureStationName">The station from which the train departs.</param>
    /// <param name="DestinationStationName">The destination station of the train.</param>
    /// <param name="ViaStationNames">An array of intermediate station the train passes through.</param>
    /// <param name="DepartureTime">The scheduled departure time of the train.</param>
    /// <param name="Train">The train associated with the departure.</param>
    /// <param name="Platform">The platform from which the train departs.</param>
    /// <param name="Sector">The sector of the station where the train is located. Can be null if it's not specific.</param>
    [TableName("Departures")]
    public record Departure(string DepartureStationName, string DestinationStationName, List<string> ViaStationNames, DateTime DepartureTime, Train Train, string Platform, string? Sector = null, int? TrainStationID = 0, int? TrainID = 0);
}
