using System;
using System.Collections.Generic;
using System.Text;

namespace JazzGuitarTabs.Application.Tabs.Models
{
   public class TabModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Style { get; set; }
        public string FileName { get; set; }
        public byte[] File { get; set; }
        public string Tags { get; set; }
        public string Author { get; set; }
        public bool IsApproved { get; set; }
    }
}
