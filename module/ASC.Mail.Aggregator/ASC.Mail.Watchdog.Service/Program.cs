/* 
 * 
 * (c) Copyright Ascensio System Limited 2010-2014
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * http://www.gnu.org/licenses/agpl.html 
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;

namespace ASC.Mail.Watchdog.Service
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(params string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0].Equals("/service"))
                {
                    if (WatchdogServiceSelfInstaller.Install())
                    {
                        MessageBox.Show("The service install successfully.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The service install error.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (args[0].Equals("/unservice"))
                {
                    if (WatchdogServiceSelfInstaller.Uninstall())
                    {
                        MessageBox.Show("The service uninstall successfully.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The service uninstall error.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (args[0].Equals("/console"))
                {
                    Watchdog service = new Watchdog();
                    service.StartConsole();
                }

            }
            else
            {
                ServiceBase.Run(new Watchdog());
            }
        }
    }
}
