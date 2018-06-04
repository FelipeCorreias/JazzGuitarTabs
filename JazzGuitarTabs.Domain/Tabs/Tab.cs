using JazzGuitarTabs.Domain.Artists;
using JazzGuitarTabs.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Domain.Tabs
{
    public class Tab : Entity
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Style { get; set; }
        public string FileName { get; set; }
        public byte[] File { get; set; }
        public string Tags { get; set; }
        public string Author { get; set; }
        public bool IsApproved { get; set; } = false;
    }
}
