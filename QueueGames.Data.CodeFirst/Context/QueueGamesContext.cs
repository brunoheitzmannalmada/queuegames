using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using QueueGames.Data.CodeFirst.Entities;

namespace QueueGames.Data.CodeFirst.Context
{
    public class QueueGamesContext : DbContext
    {
        public QueueGamesContext() : base("QueueGamesContext")
        {
            Database.SetInitializer<QueueGamesContext>(new CreateDatabaseIfNotExists<QueueGamesContext>());
        }

        public DbSet<Games> Games { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
