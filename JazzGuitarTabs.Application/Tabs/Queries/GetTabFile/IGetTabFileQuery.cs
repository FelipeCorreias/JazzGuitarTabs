using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Application.Tabs.Queries.GetTabFile
{
  public interface IGetTabFileQuery
    {
        byte[] Execute(int tabID);
    }
}
