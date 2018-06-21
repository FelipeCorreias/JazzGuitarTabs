using System;
using System.Text;
using JazzGuitarTabs.Application.Artists.Queries.GetArtistsList;
using JazzGuitarTabs.Application.Interfaces;
using JazzGuitarTabs.Application.Tabs.Commands.CreateTab;
using JazzGuitarTabs.Application.Tabs.Queries.GetTabDetail;
using JazzGuitarTabs.Application.Tabs.Queries.GetTabFile;
using JazzGuitarTabs.Application.Tabs.Queries.GetTabsListByArtist;
using JazzGuitarTabs.Application.Tabs.Queries.GetTabsListLast;
using JazzGuitarTabs.Common.Strings;
using JazzGuitarTabs.Domain.Tabs;
using JazzGuitarTabs.Persistance;
using Microsoft.Extensions.DependencyInjection;

namespace JazzGuitarTabs.IoC
{
    public static class DIContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            //PERSISTANCE
            services.AddScoped<DatabaseService>();
            services.AddScoped<IRepository<Tab>,Repository<Tab>>();

            //APPLICATION
            // COMMANDS
            services.AddTransient<ICreateTabCommand, CreateTabCommand>();
            // QUERIES
            services.AddTransient<IGetTabsListByArtistQuery, GetTabListByArtistQuery>();
            services.AddTransient<IGetTabFileQuery, GetTabFileQuery>();
            services.AddTransient<IGetTabDetailQuery, GetTabDetailQuery>();
            services.AddTransient<IGetArtistsListQuery, GetArtistsListQuery>();
            services.AddTransient<IGetTabsListLastQuery, GetTabsListLastQuery>();

            // COMMON
            services.AddTransient<IStringService, StringService>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        }
    }
}
