namespace Curso.Producer
{
    public interface IProducer
    {
        void ProduceMessage(string topic, string message);
    }
}
