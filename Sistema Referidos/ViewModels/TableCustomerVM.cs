using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_Referidos.Models
{
    public class TableCustomerVM
    {

        public string TableNro { get; set; }

        public DateTime TableCustomerDate { get; set; }

        public string Description { get; set; }

        public List<CustomerAtTable> CustomerAtTables { get; set; }
    }
}