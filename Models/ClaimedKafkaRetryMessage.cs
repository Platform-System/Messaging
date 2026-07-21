namespace Messaging.Models;

public sealed record ClaimedKafkaRetryMessage(Guid Id, string Payload, int RetryCount);
