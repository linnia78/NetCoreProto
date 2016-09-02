using Infastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageProto.Data
{
    public class MessageContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuraiton = new ConfigurationBuilder()
                .AddAppSettings()
                .Build();

            optionsBuilder.UseSqlServer(configuraiton.GetConnectionString(ConnectionString.MESSAGE_CONTEXT_CONNECTION_STRING));

            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Message> Messages { get; set; }
    }
}
