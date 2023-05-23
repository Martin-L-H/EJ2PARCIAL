using Microsoft.EntityFrameworkCore;
using EJ2PARCIAL.Models;
using System;

namespace EJ2PARCIAL.DAL
{
    public class MotoContext : DbContext
    {
        public MotoContext(DbContextOptions<MotoContext> options) : base(options)
        {

        }
        public DbSet<Moto> Motos { get; set; }
    }
}
