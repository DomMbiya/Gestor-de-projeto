using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using keisarmindproject.Models;

namespace keisarmindproject.Data
{
    public class keisarmindprojectContext : DbContext
    {
        public keisarmindprojectContext (DbContextOptions<keisarmindprojectContext> options)
            : base(options)
        {
        }

        public DbSet<keisarmindproject.Models.UsuarioModel> UsuarioModel { get; set; } = default!;
    }
}
