using JazzGuitarTabs.Application.Artists.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Application.Artists.Queries.GetArtistsList
{
    public interface IGetArtistsListQuery
    {
        List<ArtistModel> Execute();
    }
}
