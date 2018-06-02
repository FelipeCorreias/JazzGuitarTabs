using System;
using System.Collections.Generic;
using System.Text;
using JazzGuitarTabs.Application.Interfaces;
using JazzGuitarTabs.Application.Tabs.Models;
using JazzGuitarTabs.Domain.Tabs;
using System.Linq;

namespace JazzGuitarTabs.Application.Tabs.Queries.GetTabsListByArtist
{
    public class GetTabListByArtistQuery : IGetTabsListByArtistQuery
    {

        private readonly IRepository<Tab> _db;

        public GetTabListByArtistQuery(IRepository<Tab> db)
        {
            _db = db;
        }

        public List<TabModel> Execute(string artist)
        {
            var tabs = _db.FindAll(t => t.Artist == artist).Select(t => new TabModel() {
                Title = t.Title,
                Artist = t.Artist,
                Author = t.Author,
                File = t.File,
                FileName = t.FileName,
                Style = t.Style,
                Tags = t.Tags
            });
            return tabs.ToList();
        }
    }
}
