//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APCS
{
    using System;
    using System.Collections.Generic;
    
    public partial class tow
    {
        public int t_id { get; set; }
        public int station { get; set; }
        public int user_number { get; set; }
        public int vehicle_number { get; set; }
        public Nullable<System.DateTime> t_date_time { get; set; }
        public string t_location { get; set; }
    
        public virtual station station1 { get; set; }
        public virtual user user { get; set; }
        public virtual vehicle vehicle { get; set; }
    }
}
