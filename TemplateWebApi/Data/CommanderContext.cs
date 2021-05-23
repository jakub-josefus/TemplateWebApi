using Microsoft.EntityFrameworkCore;
using TemplateWebApi.Models;

namespace TemplateWebApi.Data
{
    public class CommanderContext: DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt){}

        public DbSet<Template> Templates { get; set; }

    }
}
