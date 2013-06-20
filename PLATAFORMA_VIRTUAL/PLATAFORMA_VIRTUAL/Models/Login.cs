using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PLATAFORMA_VIRTUAL.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Ingrese datos porfavor")]
        [StringLength(100, ErrorMessage = "Minimo 4 caracteres", MinimumLength = 4)]
        [Display(Name = "Nick")]
        [DataType(DataType.Text)]
        public string nick { get; set; }


        [Required(ErrorMessage = "Ingrese datos por favor")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
    public class aux
    {
        public string id { get; set; }
        public string nom { get; set; }

    }
}