using JazzGuitarTabs.Application.Tabs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Application.Tabs.Queries.GetTabsListLast
{
  public  interface IGetTabsListLastQuery
    {
        List<TabModel> Execute(int top);
    }
}
