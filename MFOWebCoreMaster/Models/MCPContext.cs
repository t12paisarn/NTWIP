using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MFOWebCoreMaster.Models
{
    public class MCPContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<MisProdOrder> mis_prod_order {get;set;}
        public DbSet<MisProdRouting> mis_prod_routing {get;set;}
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=PTTGAS02\\TH2K16;Database=MCP_DEV;user=sa;password=P@ssw0rd;Trusted_Connection=False;");
            }
        }

    }
}
