using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VUK_Manager.Models;

namespace VUK_Manager.Context
{
    public class VUKContext : DbContext
    {
        public DbSet<Prices> Prices { get; set; }

        public VUKContext() : base("SQLConnection") { }
    }
}
