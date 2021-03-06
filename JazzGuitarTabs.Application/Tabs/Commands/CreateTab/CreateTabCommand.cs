﻿using System;
using System.Collections.Generic;
using System.Text;
using JazzGuitarTabs.Application.Interfaces;
using JazzGuitarTabs.Application.Tabs.Models;
using JazzGuitarTabs.Common.Strings;
using JazzGuitarTabs.Domain.Tabs;

namespace JazzGuitarTabs.Application.Tabs.Commands.CreateTab
{
    public class CreateTabCommand : ICreateTabCommand
    {
        private readonly IRepository<Tab> _db;

        public CreateTabCommand(IRepository<Tab> db)
        {
            _db = db;
        }

        public void Execute(TabModel tabModel, byte[] file)
        {
            var tab = new Tab
            {
                Title = tabModel.Title,
                Artist = tabModel.Artist,
                Author = tabModel.Author,
                Style = tabModel.Style,
                FileName = tabModel.FileName,
                File = file,
                Tags = tabModel.Tags,
            };

            _db.Add(tab);
        }
    }
}
