using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Polling.Network;

namespace Polling
{
    /// <summary>
    /// Main class.
    /// </summary>
    public class Program
    {
        //public static Boolean active = true;

        /// <summary>
        /// Entry method.
        /// </summary>
        /// <param name="args">arguments</param>
      //  public static void Main(string[] args)
        //{
            //COMReceiver.GetInstance().DeleteAllMessages();

            //EventSender.GetInstance().StartConnection(ServerInformation.LOCAL_HOST, ServerInformation.DEFAULT_PORT);

            /* Get input from COM */
           // COMReceiver.GetInstance().StartReceivingMessages();

            /* Get WebPage URL from IE */
           // WebPageWatcher.GetInstance().StartMonitoring();

            /* Monitors files */
            //GeneralFileWatcher.GetInstance().Start();
           // FileMonitor.GetInstance().StartMonitoring(true,true,true,true);

            

            /* Monitors Apps/Programs */
           // ProgramWatcher.GetInstance().StartMonitoring();

            /* Monitors Folder/Directories */
           // FolderMonitor.GetInstance().StartMonitoring();

            // Monitor emails
            //EmailMonitor.GetInstance().StartMonitoring();

           // while (true)
           // {
                // runs indefinitely until terminated by user via task manager
             //   if(Console.ReadLine()=="end") {
                //    Log.reset();
                   // break;
              //  }
            //}
       // }
    }
}
