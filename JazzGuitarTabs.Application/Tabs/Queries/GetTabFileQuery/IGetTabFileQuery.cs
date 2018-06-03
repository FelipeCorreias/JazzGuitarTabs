using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Application.Tabs.Queries.GetTabFileQuery
{
  public interface IGetTabFileQuery
    {
        byte[] Execute(int tabID);
    }
}
