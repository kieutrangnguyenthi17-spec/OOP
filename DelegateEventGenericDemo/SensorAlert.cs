
using System;

namespace DelegateEventGenericDemo
{
    // 3b) Subscriber: generic alert with custom predicate and message
    public class SensorAlert<T>
    {
        private readonly Func<SensorReading<T>, bool> _predicate;
        private readonly Func<SensorReading<T>, string> _messageFactory;
        public string Name { get; }

        public SensorAlert(string name,
                           Func<SensorReading<T>, bool> predicate,
                           Func<SensorReading<T>, string> messageFactory)
        {
            Name = name;
            _predicate = predicate;
            _messageFactory = messageFactory;
        }

        public void Handle(in SensorReading<T> r)
        {
            if (_predicate(r))
            {
                Console.WriteLine($"[ALERT:{Name}] {_messageFactory(r)}");
            }
        }
    }
}
