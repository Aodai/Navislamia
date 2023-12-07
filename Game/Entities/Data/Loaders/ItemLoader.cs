﻿using System.Collections.Generic;
using System.Data;

using Navislamia.Database;
using Navislamia.Notification;
using Navislamia.Data.Interfaces;
using Navislamia.Data.Entities;
using Navislamia.Data.Repositories;

namespace Navislamia.Data.Loaders;

public class ItemLoader : RepositoryLoader, IRepositoryLoader
{
    DbConnectionManager _dbConnectionManager;

    public ItemLoader(INotificationModule notificationModule, DbConnectionManager dbConnectionManager) : base(notificationModule)
    {
        _dbConnectionManager = dbConnectionManager;
    }

    public List<IRepository> Init()
    {
        Tasks.Add(new ItemEffectRepository(_dbConnectionManager.WorldConnection).Load());
        Tasks.Add(new SetItemEffectRepository(_dbConnectionManager.WorldConnection).Load());

        if (!Execute())
            return null;

        var effects = new List<EffectInfo>(Repositories[0].GetData<EffectInfo>());
        var itemEffects = Repositories[1].GetData<SetItemEffect>();

        foreach (SetItemEffect itemEffect in itemEffects)
        {
            for (int i = 0; i < SetItemEffect.MAX_OPTIONS; i++)
            {
                if (itemEffect.EffectID > 0)
                    itemEffect.Effects = effects.FindAll(e => e.EffectID == itemEffect.EffectID);
            }
        }

        return this.Repositories;
    }
}