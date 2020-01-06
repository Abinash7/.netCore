using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCapp.Models
{
    public class UserInfo
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
