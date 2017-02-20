using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sistema_Referidos.Context
{
    public class ReferidosContext : DbContext

    {
        public ReferidosContext()
            : base("name=ReferidosContext")
        {
        }

        public System.Data.Entity.DbSet<Sistema_Referidos.Models.Table> Tables { get; set; }

        public System.Data.Entity.DbSet<Sistema_Referidos.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<Sistema_Referidos.Models.TablePosition> TablePositions { get; set; }
    }
}