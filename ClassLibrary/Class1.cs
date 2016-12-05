using System.ServiceModel;

namespace CommunicationInterface
{
    [ServiceContract] // Говорим WCF что это интерфейс для запросов сервису
    public interface IMyObject
    {
        [OperationContract] // Делегируемый метод.
        string GetCommandString(int i);
    }
}