using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddtoCartmodule.Models
{

    //Helping class

    public class cart
    {
        public int Book_id { get; set; }
        public string Book_name { get; set; }
        public float Book_price { get; set; }
        public int qty { get; set; }
        public float bill { get; set; }



    }
}