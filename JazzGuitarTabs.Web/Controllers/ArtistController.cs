using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JazzGuitarTabs.Application.Artists.Models;
using JazzGuitarTabs.Application.Artists.Queries.GetArtistsList;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JazzGuitarTabs.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ArtistController : Controller
    {
        IGetArtistsListQuery _getArtistsList;

        public ArtistController(IGetArtistsListQuery getArtistsList)
        {
            _getArtistsList = getArtistsList;
        }

        // GET: api/Artist
        [HttpGet]
        public IEnumerable<ArtistModel> Get()
        {
            return _getArtistsList.Execute();
        }
    }
}