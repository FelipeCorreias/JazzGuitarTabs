using JazzGuitarTabs.Application.Interfaces;
using JazzGuitarTabs.Domain.Tabs;
using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Application.Tabs.Queries.GetTabFile
{
    public class GetTabFileQuery : IGetTabFileQuery
    {

        private readonly IRepository<Tab> _db;

        public GetTabFileQuery(IRepository<Tab> db)
        {
            _db = db;
        }
        public byte[] Execute(int tabID)
        {
            return _db.Get(tabID).File;
        }
    }
}
