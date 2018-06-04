using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JazzGuitarTabs.Application.Artists.Models;
using JazzGuitarTabs.Application.Interfaces;
using JazzGuitarTabs.Domain.Tabs;

namespace JazzGuitarTabs.Application.Artists.Queries.GetArtistsList
{
    public class GetArtistsListQuery : IGetArtistsListQuery
    {
        IRepository<Tab> _db;

        public GetArtistsListQuery(IRepository<Tab> db)
        {
            _db = db;
        }

        public List<ArtistModel> Execute()
        {
            return _db.FindAll(t => t.IsApproved).GroupBy(t => t.Artist).Select(t => new ArtistModel()
            {
                Name = t.FirstOrDefault().Artist
            }).OrderBy(t => t.Name).ToList();
        }
    }
}
