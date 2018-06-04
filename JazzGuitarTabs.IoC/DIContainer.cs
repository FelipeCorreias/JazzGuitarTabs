﻿using System;
using JazzGuitarTabs.Application.Artists.Queries.GetArtistsList;
using JazzGuitarTabs.Application.Interfaces;
using JazzGuitarTabs.Application.Tabs.Commands.CreateTab;
using JazzGuitarTabs.Application.Tabs.Queries.GetTabDetail;
using JazzGuitarTabs.Application.Tabs.Queries.GetTabFile;
using JazzGuitarTabs.Application.Tabs.Queries.GetTabsListByArtist;
using JazzGuitarTabs.Domain.Tabs;
using JazzGuitarTabs.Persistance;
using Microsoft.Extensions.DependencyInjection;

namespace JazzGuitarTabs.IoC
{
    public static class DIContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<DatabaseService>();
            services.AddScoped<IRepository<Tab>,Repository<Tab>>();
            // COMMANDS
            services.AddTransient<ICreateTabCommand, CreateTabCommand>();
            // QUERIES
            services.AddTransient<IGetTabsListByArtistQuery, GetTabListByArtistQuery>();
            services.AddTransient<IGetTabFileQuery, GetTabFileQuery>();
            services.AddTransient<IGetTabDetailQuery, GetTabDetailQuery>();
            services.AddTransient<IGetArtistsListQuery, GetArtistsListQuery>();

        }
    }
}