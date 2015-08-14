using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkyLo.Models
{
    public class RoleViewModel
    {
        [Display(Name = "Role Name")]
        [Required]
        public string RoleName { get; set; }


        [Display(Name = "Role Description")]
        [Required]
        public string RoleDescription { get; set; }
    }

    public class UserRoleViewModel
    {
        [Display(Name = "Username")]
        [Required]
        public string SelectUser { get; set; }

        [Display(Name = "User role")]
        [Required]
        public string SelectRole { get; set; }
    }
}