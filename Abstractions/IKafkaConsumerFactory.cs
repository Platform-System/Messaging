using Confluent.Kafka;

namespace Messaging.Abstractions;

public interface IKafkaConsumerFactory
{
    IConsumer<string, string> Create(string groupId, params string[] topics);
}
