using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema_Referidos.Models
{
    public class TablePosition
    {
        [Key]
        public int IdTablePosition { get; set; }

        public int IdCustomer { get; set; } //Clave Foránea Customer

        public virtual Customer Customer { get; set; }

        public int IdTable { get; set; } //Clave Foránea Table

        public virtual Table Table { get; set; }
    }
}