//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddtoCartmodule.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BTransaction
    {
        public int Transaction_id { get; set; }
        public Nullable<int> Transaction_bill { get; set; }
        public Nullable<int> Transaction_qty { get; set; }
        public Nullable<System.DateTime> Transaction_date { get; set; }
        public Nullable<int> Transaction_price { get; set; }
        public Nullable<int> Book_id { get; set; }
        public Nullable<int> in_id { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}
