using System;
using System.ServiceModel;
using CommunicationInterface;

namespace CommunicationInterface
{
    public class MyObject : IMyObject
    {
        public string GetCommandString(int i)
        {
            switch (i)
            {
                case 1:// TODO: Реализация старта выполнения ваших команд
                    return "Начало обработки";

                case 0:// TODO: Реализация остановки выполнения ваших команд
                    return "Конец обработки";

                default:// TODO: Выполнение какой-либо вашей команды
                    return "Получил " + i.ToString();
            }
        }
    }
}

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(MyObject), new Uri("http://localhost:1050/TestService"));
            host.AddServiceEndpoint(typeof(IMyObject), new BasicHttpBinding(), "");
            host.Open();
            Console.WriteLine("Сервер запущен");
            Console.ReadLine();

            host.Close();
        }
    }
}