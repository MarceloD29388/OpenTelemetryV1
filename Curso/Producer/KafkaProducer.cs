using Confluent.Kafka;

namespace Curso.Producer
{
    public class KafkaProducer : IProducer
    {
        private readonly ProducerConfig _config;
       
        public KafkaProducer(KafkaOptions options)
        {
            _config = new ProducerConfig { BootstrapServers = options.GetServer() };
        }

        public void ProduceMessage(string topic, string message)
        {
            using var producer = new ProducerBuilder<Null, string>(_config).Build();
            try
            {
                var deliveryReport = producer.ProduceAsync(topic, new Message<Null, string> { Value = message }).GetAwaiter().GetResult();

                Console.WriteLine($"Delivered '{deliveryReport.Value}' to '{deliveryReport.TopicPartitionOffset}'");
                producer.Flush();
            }
            catch (ProduceException<Null, string>)
            {
                throw;
            }
        }
    }
}
