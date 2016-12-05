using System;
using System.ServiceModel;
using CommunicationInterface;

namespace Client
{

    class Program
    {
        static void Main(string[] args)
        {
            Uri tcpUri = new Uri("http://localhost:1050/TestService");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<IMyObject> factory = new ChannelFactory<IMyObject>(binding, address);
            IMyObject service = factory.CreateChannel();

            Console.WriteLine("Вызываю метод сервиса...?");
            Console.WriteLine(service.GetCommandString(1));
            Console.WriteLine(service.GetCommandString(2));
            Console.WriteLine(service.GetCommandString(20));
            Console.WriteLine(service.GetCommandString(1562492));
            Console.WriteLine(service.GetCommandString(0));
            Console.ReadLine();
        }
    }
}