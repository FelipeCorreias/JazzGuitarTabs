using System.Collections.Generic;
using System.Linq;
using JazzGuitarTabs.Application.Interfaces;
using JazzGuitarTabs.Application.Tabs.Models;
using JazzGuitarTabs.Common.Strings;
using JazzGuitarTabs.Domain.Tabs;

namespace JazzGuitarTabs.Application.Tabs.Queries.GetTabsListLast
{
    public class GetTabsListLastQuery : IGetTabsListLastQuery
    {
        private readonly IRepository<Tab> _db;
        private readonly IStringService _stringService;

        public GetTabsListLastQuery(IRepository<Tab> db, IStringService stringService)
        {
            _db = db;
            _stringService = stringService;
        }

        List<TabModel> IGetTabsListLastQuery.Execute(int top)
        {
            var tabs = _db.FindBy(t => t.IsApproved).OrderByDescending(t => t.Id).Take(top).Select(t => new TabModel()
            {
                Id = t.Id,
                Title = t.Title,
                Artist = t.Artist,
                Author = t.Author,
                FileName = t.FileName,
                Style = t.Style,
                Tags = t.Tags,
                IsApproved = t.IsApproved,
                Alias = _stringService.GenerateSlug(t.Title)
            });
            return tabs.ToList();
        }
    }
}