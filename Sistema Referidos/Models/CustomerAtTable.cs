using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema_Referidos.Models
{
    public class CustomerAtTable
    {
        [Key]
        public int idCustomerAtTable { get; set; }

        public string NameCustomer { get; set; }

        public string NameRecomender { get; set; }
        
        public DateTime DateAtTable { get; set; }
        public int? idTable { get; set; } //Clave Foránea

        public virtual Table Table { get; set; }

        
    }
}