using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JazzGuitarTabs.Application.Artists.Models;
using JazzGuitarTabs.Application.Interfaces;
using JazzGuitarTabs.Application.Tabs.Models;
using JazzGuitarTabs.Domain.Tabs;

namespace JazzGuitarTabs.Application.Tabs.Queries.GetTabDetail
{
    public class GetTabDetailQuery : IGetTabDetailQuery
    {
        IRepository<Tab> _db;

        public GetTabDetailQuery(IRepository<Tab> db)
        {
            _db = db;
        }

        public TabModel Execute(int tabID)
        {
            return _db.FindBy(t => t.Id == tabID).Select(t => new TabModel() {
                Artist = t.Artist,
                Author = t.Author,
                FileName = t.FileName,
                Id = t.Id,
                IsApproved = t.IsApproved,
                Style = t.Style,
                Tags = t.Tags,
                Title = t.Title
            }).FirstOrDefault();
        }
    }
}
