using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Football.Models
{
    public class FootballContext : DbContext
    {
        public FootballContext() : base("FootballContext")
        { }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}