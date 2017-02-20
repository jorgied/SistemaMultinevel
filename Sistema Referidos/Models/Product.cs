using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema_Referidos.Models
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "Descripción")]
        public string ProductDescription { get; set; }

        [Display(Name = "Costo")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal? Cost { get; set; }

        public string Image { get; set; }
        
        public int IdCustomer { get; set; } //claveForanea
    }
}