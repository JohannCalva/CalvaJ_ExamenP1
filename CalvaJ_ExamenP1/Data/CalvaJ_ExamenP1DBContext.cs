using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CalvaJ_ExamenP1.Models;

    public class CalvaJ_ExamenP1DBContext : DbContext
    {
        public CalvaJ_ExamenP1DBContext (DbContextOptions<CalvaJ_ExamenP1DBContext> options)
            : base(options)
        {
        }

        public DbSet<CalvaJ_ExamenP1.Models.Propietario> Propietario { get; set; } = default!;

public DbSet<CalvaJ_ExamenP1.Models.Mascota> Mascota { get; set; } = default!;

public DbSet<CalvaJ_ExamenP1.Models.Cita> Cita { get; set; } = default!;
    }
