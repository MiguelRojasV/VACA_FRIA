using Microsoft.EntityFrameworkCore;
using VACA_FRIA.Models;

namespace VACA_FRIA.Context
{
        public class MiContext : DbContext
        {
            public MiContext(DbContextOptions options) : base(options)
            {

            }

            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Cliente> Clientes { get; set; }

        }
    }

