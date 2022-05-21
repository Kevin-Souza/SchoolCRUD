
using Microsoft.EntityFrameworkCore;
using TemplateBootstrap.Models;

namespace TemplateBootstrap.Data
{
    public class AppContext
    {
        public class AppCont : DbContext
        {
            public AppCont(DbContextOptions<AppCont> options) : base(options)
            {

            }
            public DbSet<funcionario> Funcionarios { get; set; }
        }
    }
}