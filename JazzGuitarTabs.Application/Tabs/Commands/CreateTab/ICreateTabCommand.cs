using JazzGuitarTabs.Application.Tabs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Application.Tabs.Commands.CreateTab
{
   public interface ICreateTabCommand
    {
        void Execute(TabModel tabModel, byte[] file);
    }
}
