using Examen_Grupo_3_Jefferson_Lara.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Grupo_3_Jefferson_Lara.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FormatoAcosoLaboral> FormatosAcosoLaboral { get; set; }



    }
}
