
using System;
using DelegateEventGenericDemo;

// Demo wiring for sensors
class Program
{
    static void Main()
    {
        // Create sensors
        var tempSensor = new Sensor<double>("TemperatureSensor-01");
        var batterySensor = new Sensor<int>("BatterySensor-01");

        // Create handlers
        var logger = new SensorLogger();
        var highTempAlert = new SensorAlert<double>(
            name: "HighTempAlert",
            predicate: r => r.NewValue > 40.0,
            messageFactory: r => $"WARNING: {r.Name} high temperature {r.NewValue:F1}°C at {r.Timestamp:t}"
        );
        var lowBatteryAlert = new SensorAlert<int>(
            name: "LowBatteryAlert",
            predicate: r => r.NewValue < 20,
            messageFactory: r => $"ALERT: {r.Name} low battery {r.NewValue}% at {r.Timestamp:t}"
        );

        // Subscribe: multiple listeners to same event
        tempSensor.OnValueChanged += logger.Handle;
        tempSensor.OnValueChanged += highTempAlert.Handle;

        batterySensor.OnValueChanged += logger.Handle;
        batterySensor.OnValueChanged += lowBatteryAlert.Handle;

        Console.WriteLine("=== Sensor simulation started ===\n");

        // Simulate updates
        double[] temps = { 28.2, 33.5, 41.3, 39.9, 42.7 };
        int[] batteries = { 100, 55, 25, 19, 15, 12 };

        foreach (var t in temps)
        {
            tempSensor.UpdateValue(t);
            System.Threading.Thread.Sleep(150);
        }

        Console.WriteLine();

        foreach (var b in batteries)
        {
            batterySensor.UpdateValue(b);
            System.Threading.Thread.Sleep(150);
        }

        Console.WriteLine("\n=== Simulation complete ===");
    }
}
