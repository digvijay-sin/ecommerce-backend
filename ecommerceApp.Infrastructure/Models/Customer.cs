using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceApp.Infrastructure.Models
{
    public class Customer
    {
        [Key]
        
        public int Cid { get; set; }

        public string Uid { get; set; }
        
        public string? MobileNumber { get; set; }
        
        public virtual User User{ get; set; }
    }
}
