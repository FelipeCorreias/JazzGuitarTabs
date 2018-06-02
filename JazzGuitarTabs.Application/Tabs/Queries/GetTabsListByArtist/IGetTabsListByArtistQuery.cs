using JazzGuitarTabs.Application.Tabs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Application.Tabs.Queries.GetTabsListByArtist
{
    public interface IGetTabsListByArtistQuery
    {
        List<TabModel> Execute(string artist);
    }
}
