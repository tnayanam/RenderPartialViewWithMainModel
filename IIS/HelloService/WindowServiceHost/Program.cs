using System.ServiceProcess;

namespace WindowServiceHost
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
                new HelloWindowService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}


/*
 * Here we want to host the WCF service in Windows Service
 * Steps: 1. create WCF Service -normally the way you create (create a class library and then add a WCF Service to it).
 * 2. create Windows Service SOltuion in VS, add reference to system.service model and servcice project that needs to be hosted
 * then in APP.CONFIG file add all the related BINDINGS and all of that. Now double click on the Serive.cs file change its name accoredingly ex: HelloWindowService
 * and now open the code and add the hosting code here. Now go back to the desgner file and right click and open add installer.
 * "Automatic"
 * now select the serviceprocessinstaller from designer view and click on properties and oselect Account as  "LocalAdmin"
 * now build the solution and makes sure its all good
 * 
 * Now our windows service is ready we just need to install it.
 * 
 * TO install:
 * go to VS folder AND YOU WILL find VS DEv CMD open that in admin mode and run below command
 * installutil -i "loction where the installer (exe) is created along with the fullnameofinstaller.exe
 * this will install the WCF Service and then you can go to service.msc and check and start the service there.
 * Now clinet shold be able to accerss the service.
 * if you ewant to uninstal the service :  installutil -u "loction where the installer (exe) is created along with the fullnameofinstaller.exe
 * 
 * 
 * 
 * 
 */
