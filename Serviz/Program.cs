﻿using System.ServiceProcess;

namespace Serviz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
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
