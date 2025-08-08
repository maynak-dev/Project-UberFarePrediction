using System;
using MLModel1_ConsoleApp1;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Passenger Count: ");
        float passengerCount = float.Parse(Console.ReadLine());
        Console.Write("Pickup Longitude: ");
        float pickupLong = float.Parse(Console.ReadLine());
        Console.Write("Pickup Latitude: ");
        float pickupLat = float.Parse(Console.ReadLine());
        Console.Write("Dropoff Longitude: ");
        float dropoffLong = float.Parse(Console.ReadLine());
        Console.Write("Dropoff Latitude: ");
        float dropoffLat = float.Parse(Console.ReadLine());
        Console.Write("Pickup Datetime(yyyy-MM-dd HH:mm:ss): ");
        string pickupDatetime = Console.ReadLine();

        var input = new MLModel1.ModelInput()
        {
            Pickup_datetime = pickupDatetime,
            Pickup_longitude = pickupLong,
            Pickup_latitude = pickupLat,
            Dropoff_longitude = dropoffLong,
            Dropoff_latitude = dropoffLat,
            Passenger_count = passengerCount
        };

        var prediction = MLModel1.Predict(input);
        Console.WriteLine($"Predicted Fare Amount: {prediction.Score}");
    }
}