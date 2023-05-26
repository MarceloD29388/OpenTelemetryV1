namespace Curso.Producer
{
    public class KafkaOptions
    {
        private readonly IConfiguration _configuration;
        public KafkaOptions(IConfiguration configuration) {
            _configuration = configuration;
        }

        public string GetServer() {
            return _configuration["Kafka:BootstrapServers"];
        }
    }
}
