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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Uid { get; set; }
        public string Name  { get; set; }
        public string MobileNumber{ get; set; }
    }
}
