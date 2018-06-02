using JazzGuitarTabs.Application.Interfaces;
using JazzGuitarTabs.Domain.Tabs;
using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Application.Tabs.Commands.ApproveTab
{
    public class ApproveTabCommand : IApproveTabCommand
    {
        private readonly IRepository<Tab> _db;

        public ApproveTabCommand(IRepository<Tab> db)
        {
            _db = db;
        }

        public void Execute(int tabID)
        {
            Tab tab = _db.Get(tabID);
            Tab tabUpdated = tab;
            tabUpdated.IsApproved = true;
            _db.Update(tabUpdated, tab);
        }
    }
}
