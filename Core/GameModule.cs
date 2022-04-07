﻿using System;
using System.Threading.Tasks;
using System.Diagnostics;

using System.IO;
using System.Linq;
using System.Reflection;

using Configuration;
using Database;
using Navislamia.Data;
using Maps;
using Network;
using Notification;
using Scripting;

using Serilog.Events;
using System.Collections.Generic;

namespace Navislamia.Game
{
    public class GameModule : IGameService
    {
        IConfigurationService configSVC;
        IDatabaseService dbSVC;
        IDataService dataSVC;
        IScriptingService scriptSVC;
        INotificationService notificationSVC;
        IMapService mapSVC;
        INetworkService networkSVC;

        public GameModule() { }

        public GameModule(IConfigurationService configurationService, INotificationService notificationService)
        {
            configSVC = configurationService;
            notificationSVC = notificationService;

            dataSVC = new DataModule();
            dbSVC = new DatabaseModule(configSVC, notificationSVC, dataSVC);
            scriptSVC = new ScriptModule(configSVC, notificationSVC);
            mapSVC = new MapModule(configSVC, notificationSVC, scriptSVC);
            networkSVC = new NetworkModule(configSVC, notificationSVC);
        }

        public int Start(string ip, int port, int backlog)
        {
            if (!configSVC.Get<bool>("skip_loading", "Scripts", false))
            {
                scriptSVC.Init();

                notificationSVC.WriteMarkup($"Successfully started and subscribed to the script service![green]\n\t-{ scriptSVC.ScriptCount } scripts loaded![/]", LogEventLevel.Debug);
            }
            else
                notificationSVC.WriteMarkup("[slowblink bold orange3]Script loading disabled![/]");


            if (!configSVC.Get<bool>("skip_loading", "Maps", false))
            {
                mapSVC.Initialize($"{Directory.GetCurrentDirectory()}\\Maps");

                notificationSVC.WriteMarkup("Successfully started and subscribed to the map service![green]\n\t- {mapSVC.MapCount.CX} maps loaded![/]", LogEventLevel.Debug);
            }
            else
                notificationSVC.WriteMarkup("[slowblink bold orange3]Map loading disabled![/]");

            dbSVC.Init();

            notificationSVC.WriteString("Successfully started and subscribed to the database service!", LogEventLevel.Debug);

            if (networkSVC.ConnectToAuth() > 0)
            {
                notificationSVC.WriteMarkup("[bold red]Network service failed to start![/]");
                return 1;
            }

            notificationSVC.WriteString("Successfully started and subscribed to the network service!", LogEventLevel.Debug);

            return 0;
        }
    }
}
