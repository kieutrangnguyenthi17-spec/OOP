
using System;

namespace DelegateEventGenericDemo
{
    // 1) Generic delegate
    public delegate void SensorHandler<T>(in SensorReading<T> reading);

    // Optional: a strongly-typed reading envelope
    public readonly record struct SensorReading<T>(
        string Name,
        T? OldValue,
        T NewValue,
        DateTimeOffset Timestamp
    );

    // 2) Generic Sensor with event
    public class Sensor<T>
    {
        private T? _currentValue;
        public string Name { get; }

        // Event using the generic delegate
        public event SensorHandler<T>? OnValueChanged;

        public Sensor(string name) => Name = name;

        // Update the value and publish the event
        public void UpdateValue(T newValue)
        {
            var reading = new SensorReading<T>(
                Name,
                _currentValue,
                newValue,
                DateTimeOffset.Now
            );

            _currentValue = newValue;
            OnValueChanged?.Invoke(reading);
        }
    }
}
