using System.Collections.Generic;
using System.Linq;
using JazzGuitarTabs.Application.Interfaces;
using JazzGuitarTabs.Application.Tabs.Models;
using JazzGuitarTabs.Domain.Tabs;

namespace JazzGuitarTabs.Application.Tabs.Queries.GetTabsListLast
{
    public class GetTabsListLastQuery : IGetTabsListLastQuery
    {
        private readonly IRepository<Tab> _db;

        public GetTabsListLastQuery(IRepository<Tab> db)
        {
            _db = db;
        }

        List<TabModel> IGetTabsListLastQuery.Execute(int top)
        {
            var tabs = _db.FindAll(t => t.IsApproved).OrderByDescending(t => t.Id).Take(top).Select(t => new TabModel()
            {
                Id = t.Id,
                Title = t.Title,
                Artist = t.Artist,
                Author = t.Author,
                FileName = t.FileName,
                Style = t.Style,
                Tags = t.Tags,
                IsApproved = t.IsApproved
            });
            return tabs.ToList();
        }
    }
}