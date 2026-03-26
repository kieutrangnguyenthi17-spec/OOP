
using System;

namespace DelegateEventGenericDemo
{
    // 3a) Subscriber: simple console logger
    public class SensorLogger
    {
        // Compatible with SensorHandler<T>
        public void Handle<T>(in SensorReading<T> r)
        {
            var oldText = r.OldValue is null ? "(init)" : r.OldValue!.ToString();
            Console.WriteLine($"[LOG {r.Timestamp:t}] {r.Name}: {oldText} -> {r.NewValue}");
        }
    }
}
