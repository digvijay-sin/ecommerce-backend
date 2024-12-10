using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceApp.Infrastructure.Models
{
    public class Admin
    {
        [Key]        
        public int Aid{ get; set; }
        [ForeignKey("Uid")]
        public string Uid { get; set; }
        public virtual User User { get; set; }
    }
}
