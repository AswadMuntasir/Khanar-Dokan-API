using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Khanar_Dokan_API.Models
{
    public class Order
    {
        [Key]
        public int oId { get; set; }

        public int hId { get; set; }

        public int uId { get; set; }

        public string oStatus { get; set; }


        public virtual History History { get; set; }
        public virtual User User { get; set; }
    }
}