using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema_Referidos.Models
{
    public class Table
    {
        [Key]
        public int idTable { get; set; }

        public TableState TableState { get; set; }

        public string TableNro { get; set; }

       
        public string Description { get; set; }

        [Display(Name = "Fecha de Creación")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:/dd/mm/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime TableCustomerDate { get; set; }

        public int TablePoints { get; set; }

        //public string Pos1 { get; set; }

        //public string Pos2 { get; set; }

        //public string Pos3 { get; set; }
        //public string Pos4 { get; set; }
        //public string Pos5 { get; set; }  
        //public string Pos6 { get; set; }
        //public string Pos7 { get; set; }

        public virtual ICollection<CustomerAtTable> CustomerAtTables { get; set; }









    }
}