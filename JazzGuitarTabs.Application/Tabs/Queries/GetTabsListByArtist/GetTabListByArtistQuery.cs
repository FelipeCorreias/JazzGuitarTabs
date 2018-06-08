﻿using System;
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
            artist = artist.Replace("-", " ");
            var tabs = _db.FindAll(t => t.Artist.ToUpper().Contains(artist.ToUpper()) && t.IsApproved).Select(t => new TabModel() {
                Id = t.Id,
                Title = t.Title,
                Artist = t.Artist,
                Author = t.Author,
                FileName = t.FileName,
                Style = t.Style,
                Tags = t.Tags,
                IsApproved = t.IsApproved
            });
            return tabs.OrderBy(x => x.Title).ToList();
        }
    }
}
