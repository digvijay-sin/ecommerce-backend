using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceApp.Infrastructure.Models
{
    public class Seller 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Uid { get; set; }
        public User User { get; set; }
        public string FullName { get; set; }
        public string DisplayName { get; set; }
        public string GSTINNumber{ get; set; }
        public string MobileNumber{ get; set; }
        public string PickupAddress { get; set; }

    }
}
