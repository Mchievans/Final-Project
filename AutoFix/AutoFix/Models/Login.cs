using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AutoFix.Models
{
    public class Login : DbContext
    {
        public Login() : base("AutoFix") { }
        private int UserID { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

    }
}
