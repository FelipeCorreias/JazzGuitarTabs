using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JazzGuitarTabs.Application.Tabs.Commands.CreateTab;
using JazzGuitarTabs.Application.Tabs.Models;
using JazzGuitarTabs.Application.Tabs.Queries.GetTabDetail;
using JazzGuitarTabs.Application.Tabs.Queries.GetTabFile;
using JazzGuitarTabs.Application.Tabs.Queries.GetTabsListByArtist;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JazzGuitarTabs.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TabController : Controller
    {
        private readonly IGetTabsListByArtistQuery _getTabsByArtist;
        private readonly ICreateTabCommand _createTab;
        private readonly IGetTabFileQuery _getTabFile;
        private readonly IGetTabDetailQuery _getTabDetail;


        public TabController(IGetTabsListByArtistQuery getTabsByArtist,
            ICreateTabCommand createTab,
            IGetTabFileQuery getTabFile,
            IGetTabDetailQuery getTabDetail)
        {
            _getTabsByArtist = getTabsByArtist;
            _createTab = createTab;
            _getTabFile = getTabFile;
            _getTabDetail = getTabDetail;
        }

        [HttpGet("Artist/{artist}")]
        public IEnumerable<TabModel> GetTabsByArtist(string artist)
        {
            return _getTabsByArtist.Execute(artist);
        }

        // GET: api/Tab/5/File
        [HttpGet("{id}/File")]
        public FileResult GetFile(int id, string file)
        {
            var tabFile = _getTabFile.Execute(id);
            var tab = _getTabDetail.Execute(id);
            return File(tabFile, "application/pdf", tab.FileName);
        }

        // POST: api/Tab
        [HttpPost]
        public void Post(TabModel tabModel, IFormFile file)
        {
            byte[] fileBytes;
            tabModel.FileName = file.FileName;
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                fileBytes = ms.ToArray();
            }
            _createTab.Execute(tabModel, fileBytes);
        }
    }
}