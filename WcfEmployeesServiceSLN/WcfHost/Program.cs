using System;
using System.ServiceModel;

namespace WcfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(
                typeof(EmployeesService.EmployeesService));

            host.Open();
            Console.WriteLine("Service is running. Press Enter to exit.");
            Console.ReadLine();

            host.Close();
        }
    }
}
