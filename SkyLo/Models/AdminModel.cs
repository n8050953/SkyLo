using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkyLo.Models
{
    public class RoleViewModel
    {
        [Display(Name="Role Name")]
        [Required]
        public string RoleName { get; set; }


        [Display(Name = "Role Description")]
        [Required]
        public string RoleDescription { get; set; }
    }
}