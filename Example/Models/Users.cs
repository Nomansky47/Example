using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Login { get; set; }  
        public string Password { get; set; }
        public bool isAdmin { get; set; }
    }
}
