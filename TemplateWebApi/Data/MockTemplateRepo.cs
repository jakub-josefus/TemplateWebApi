using System;
using System.Collections.Generic;
using TemplateWebApi.Models;

namespace TemplateWebApi.Data
{
    public class MockTemplateRepo : InterfaceTemplate
    {
        public IEnumerable<Template> GetAppCommands()
        {
            var templates = new List<Template>
            {
                new Template(0,"Boil an egg","Boil water","Kettle & Pan"),
                new Template(1,"Cut bread","Get a knife","knife & chopping board"),
                new Template(2, "Make cup of tea", "Place teabag in cut", "Ket & cup"),
        };
            return templates;
        }

        public Template GetCommandById(int id)
        {
            return new Template(0,"Boil an egg","Boil water","yes");
        }
    }
}
