using JazzGuitarTabs.Application.Tabs.Models;
using JazzGuitarTabs.Domain.Tabs;
using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Application.Tabs.Queries.GetTabDetail
{
    public interface IGetTabDetailQuery
    {
        TabModel Execute(int tabID);

    }
}
