using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace CoreToWCFSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here we go...");

			Binding binding = null;
			binding = new BasicHttpBinding(BasicHttpSecurityMode.None);


			var factory = new ChannelFactory<IService1>(binding, new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WCFSample/Service1"));

			var serviceProxy = factory.CreateChannel();

			var result = serviceProxy.GetData(5);

			Console.WriteLine(result.ToString());

			var test = Console.ReadLine();
        }
    }
}
