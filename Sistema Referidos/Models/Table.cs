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
        public int IdTable { get; set; }

        public TableState TableState { get; set; }
       
        public string TableDescription { get; set; }

        [Display(Name = "Fecha de Creación")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:/yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime TableDate { get; set; }

        public int TablePoints { get; set; }

        public virtual ICollection<TablePosition> TablePositions { get; set; }









    }
}