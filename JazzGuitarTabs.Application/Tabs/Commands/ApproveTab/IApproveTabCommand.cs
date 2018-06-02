using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Application.Tabs.Commands.ApproveTab
{
   public interface IApproveTabCommand
    {
        void Execute(int tabID);
    }
}
