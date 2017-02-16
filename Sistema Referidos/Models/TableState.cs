using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema_Referidos.Models
{
    public enum TableState
    {
        [Display(Name = "Mesa Abierta")]
        Abierta = 0,

        [Display(Name = "Mesa Cerrada")]
        Cerrada = 1,

        [Display(Name = "Mesa Bloqueada")]
        Bloqueada = 2,

        [Display(Name = "Mesa Inactiva")]
        Inactiva = 3,

     

    }
}