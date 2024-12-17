using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Muzsi_Levente_Lab2.MODELS;

namespace Muzsi_Levente_Lab2.Data
{
    public class Muzsi_Levente_Lab2Context : DbContext
    {
        public Muzsi_Levente_Lab2Context (DbContextOptions<Muzsi_Levente_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Muzsi_Levente_Lab2.MODELS.Book> Book { get; set; } = default!;
        public DbSet<Muzsi_Levente_Lab2.MODELS.Publisher> Publisher { get; set; } = default!;
    }
}
