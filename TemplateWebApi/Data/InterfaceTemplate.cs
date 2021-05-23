using System.Collections.Generic;
using TemplateWebApi.Models;

namespace TemplateWebApi.Data
{
    public interface InterfaceTemplate
    {
        IEnumerable<Template> GetAppCommands();
        Template GetCommandById(int id);
    }
}
