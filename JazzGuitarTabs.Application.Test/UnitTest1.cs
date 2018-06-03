using JazzGuitarTabs.Application.Tabs.Commands.CreateTab;
using JazzGuitarTabs.Application.Tabs.Models;
using JazzGuitarTabs.Domain.Tabs;
using JazzGuitarTabs.Persistance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JazzGuitarTabs.Application.Test
{
    [TestClass]
    public class UnitTest1
    {


        public UnitTest1()
        {
        }

        [TestMethod]
        public void TestMethod1()
        {
            DatabaseService db = new DatabaseService();
            Repository<Tab> rep = new Repository<Tab>(db);
            CreateTabCommand create = new CreateTabCommand(rep);
            TabModel tab = new TabModel();

            tab.Title = "teste";


            //create.Execute(tab);

        }
    }
}
