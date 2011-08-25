using System.ServiceProcess;

namespace Serviz
{
    static class Program
    {
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
			{ 
				new Serviz() 
			};
            ServiceBase.Run(ServicesToRun);
        }
    }
}
